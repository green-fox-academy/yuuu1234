using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace ImageUploadService.Services
{
    public class ImageUploadService : IImageUploadService
    {
        private readonly CloudStorageAccount account;
        private readonly string containerName;

        public ImageUploadService(StorageAccountWrapper storageAccountWrapper)
        {
            account = storageAccountWrapper.Account;
            containerName = "rawimages";
        }

        public async Task<Uri> UploadImage(string imageName, Stream stream)
        {
            var blobClient = account.CreateCloudBlobClient();

            var blobContainer = blobClient.GetContainerReference(containerName);
            await blobContainer.CreateIfNotExistsAsync();
            blobContainer.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            var cloudBlockBlob = blobContainer.GetBlockBlobReference(imageName);
            await cloudBlockBlob.UploadFromStreamAsync(stream);

            return cloudBlockBlob.Uri;
        }
    }
}