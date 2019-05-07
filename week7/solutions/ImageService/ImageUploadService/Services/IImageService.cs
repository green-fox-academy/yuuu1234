using System.Collections.Generic;
using System.Threading.Tasks;
using ImageUploadService.Controllers;
using ImageUploadService.Models;

namespace ImageUploadService.Services
{
    public interface IImageService
    {
        Task SaveImage(Image image);
        Task SaveResizedImage(ResizedImage resizedImage);
        Task<List<Image>> FindAllAsync();
        Task<Image> FindAsync(long id);
    }
}