using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageUploadService.Controllers;
using ImageUploadService.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageUploadService.Services
{
    public class ImageService : IImageService
    {
        private readonly ApplicationContext applicationContext;

        public ImageService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public async Task SaveImage(Image image)
        {
            applicationContext.Images.Add(image);
            await applicationContext.SaveChangesAsync();
        }

        public async Task SaveResizedImage(ResizedImage resizedImage)
        {
            var rawImage = await applicationContext.Images
                .Include(i => i.ResizedVariants)
                .SingleOrDefaultAsync(i => i.ImageId == resizedImage.RawImageId);

            if (rawImage == null)
            {
                throw new ArgumentException(nameof(resizedImage));
            }

            var image = new Image
            {
                FileName = resizedImage.FileName,
                Size = resizedImage.Size,
                Url = resizedImage.Url
            };

            applicationContext.Images.Add(image);
            rawImage.ResizedVariants.Add(image);

            await applicationContext.SaveChangesAsync();
        }

        public Task<List<Image>> FindAllAsync()
        {
            return applicationContext
                .Images
                .Include(i => i.ResizedVariants)
                .Where(i => i.RawImage == null)
                .ToListAsync();
        }

        public Task<Image> FindAsync(long id)
        {
            return applicationContext.Images.FindAsync(id);
        }
    }
}