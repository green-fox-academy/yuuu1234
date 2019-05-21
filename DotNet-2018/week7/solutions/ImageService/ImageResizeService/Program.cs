using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ImageResizeService
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenSource = new CancellationTokenSource();
            string connectionString = "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=szelpeimageservice;AccountKey=vSVBKerU0h0ZW+RGMHfwikhQ5kpDXc74p8fNDwbG4zjSR+L7i7H7Lbn9i2J0fIiIE5sBej2H0esm2Ztw9ypKfQ==";
            var storageAccountWrapper = new StorageAccountWrapper(connectionString);

            var messagePump = new MessagePump(storageAccountWrapper);
            var imageServiceClient = new ImageServiceClient(new HttpClient());
            var messageHandler = new MessageHandler(storageAccountWrapper, imageServiceClient);

            var task = Task.Factory.StartNew(async () => await messagePump.Do(tokenSource.Token, messageHandler.HandleMessage), TaskCreationOptions.LongRunning);

            Console.WriteLine("Image Resize started...");

            task.Unwrap().Wait();

            Console.WriteLine("End");
        }
    }
}
