using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;

namespace ImageResizeService
{
    public class MessageHandler
    {
        private readonly StorageAccountWrapper storageAccountWrapper;
        private readonly ImageServiceClient imageServiceClient;
        private readonly string containerName;

        public MessageHandler(StorageAccountWrapper storageAccountWrapper, ImageServiceClient imageServiceClient)
        {
            this.storageAccountWrapper = storageAccountWrapper;
            this.imageServiceClient = imageServiceClient;
            containerName = "rawimages";
        }

        public async Task HandleMessage(CloudQueueMessage message)
        {
            var serializedMessage = message.AsString;
            var image = JsonConvert.DeserializeObject<Image>(serializedMessage);
            Console.WriteLine($"Message received: {image.FileName}");

            var rawImageStream = await DownloadImageToStream(image.FileName);

            var resizedImageStream = ResizeImage(rawImageStream);

            var newImageName = Path.Combine(Path.GetFileNameWithoutExtension(image.FileName) + "_small.png");
            var uri = await UploadImage(newImageName, resizedImageStream);

            await imageServiceClient.SaveImage(image.ImageId, newImageName, resizedImageStream.Length, uri.ToString());

            Console.WriteLine($"{newImageName} uploaded successfully");
        }

        private Stream ResizeImage(Stream imageStream)
        {
            var resizedImageStream = new MemoryStream();
            Bitmap image = new Bitmap(imageStream);

            Bitmap resizeImage = new Bitmap(image, 300, (int)Math.Round((double)image.Height / image.Width * 300));

            resizeImage.Save(resizedImageStream, ImageFormat.Png);

            resizedImageStream.Seek(0, SeekOrigin.Begin);
            return resizedImageStream;
        }

        private async Task<Stream> DownloadImageToStream(string imageName)
        {
            var stream = new MemoryStream();
            var blobContainer = await GetCloudBlobContainer(storageAccountWrapper.Account);
            var cloudBlockBlob = blobContainer.GetBlockBlobReference(imageName);

            await cloudBlockBlob.DownloadToStreamAsync(stream);

            return stream;
        }

        private async Task<Uri> UploadImage(string imageName, Stream stream)
        {
            var blobContainer = await GetCloudBlobContainer(storageAccountWrapper.Account);

            var cloudBlockBlob = blobContainer.GetBlockBlobReference(imageName);
            await cloudBlockBlob.UploadFromStreamAsync(stream);

            return cloudBlockBlob.Uri;
        }

        private async Task<CloudBlobContainer> GetCloudBlobContainer(CloudStorageAccount account)
        {
            var blobClient = account.CreateCloudBlobClient();

            var blobContainer = blobClient.GetContainerReference(containerName);
            await blobContainer.CreateIfNotExistsAsync();
            return blobContainer;
        }
    }
}