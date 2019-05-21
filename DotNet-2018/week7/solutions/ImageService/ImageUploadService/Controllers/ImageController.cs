using System.Threading.Tasks;
using ImageUploadService.Models;
using ImageUploadService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageUploadService.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageUploadService imageUploadService;
        private readonly IMessageQueueService messageQueueService;
        private readonly IImageService imageService;

        public ImageController(IImageUploadService imageUploadService, IMessageQueueService messageQueueService, IImageService imageService)
        {
            this.imageUploadService = imageUploadService;
            this.messageQueueService = messageQueueService;
            this.imageService = imageService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var images = await imageService.FindAllAsync();
            return View(images);
        }

        [HttpGet("view/{id}")]
        public async Task<IActionResult> View(long id)
        {
            Image image = await imageService.FindAsync(id);
            return View(image);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile formImage)
        {
            var imageName = formImage.FileName;
            var stream = formImage.OpenReadStream();

            var uri = await imageUploadService.UploadImage(imageName, stream);

            var image = new Image
            {
                FileName = imageName,
                Size = formImage.Length,
                Url = uri.ToString()
            };

            await imageService.SaveImage(image);

            await messageQueueService.EnqueueMessage(image);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost("image")]
        public async Task SaveImage([FromBody] Image image)
        {
            await imageService.SaveImage(image);
        }

        [HttpPost("resized-image")]
        public async Task SaveImage([FromBody] ResizedImage image)
        {
            await imageService.SaveResizedImage(image);
        }

    }

    public class ResizedImage
    {
        public long RawImageId { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public string Url { get; set; }
    }
}