using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageUploadService.Services
{
    public interface IImageUploadService
    {
        Task<Uri> UploadImage(string imageName, Stream stream);
    }
}