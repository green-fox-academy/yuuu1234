using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ImageResizeService
{
    public class ImageServiceClient
    {
        private readonly HttpClient httpClient;

        public ImageServiceClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task SaveImage(long rawImageId, string fileName, long fileSize, string url)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(new
            {
                RawImageId = rawImageId,
                FileName = fileName,
                Size = fileSize,
                Url = url
            }), Encoding.UTF8, "application/json");

            await httpClient.PostAsync("https://localhost:44307/resized-image", stringContent);
        }
    }
}
