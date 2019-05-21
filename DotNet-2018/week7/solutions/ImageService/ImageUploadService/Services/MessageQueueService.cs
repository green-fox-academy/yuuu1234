using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;

namespace ImageUploadService.Services
{
    public class MessageQueueService : IMessageQueueService
    {
        private readonly StorageAccountWrapper storageAccountWrapper;
        private readonly string queueName;

        private CloudStorageAccount Account => storageAccountWrapper.Account;

        public MessageQueueService(StorageAccountWrapper storageAccountWrapper)
        {
            this.storageAccountWrapper = storageAccountWrapper;
            queueName = "imagequeue";
        }

        public async Task EnqueueMessage(string message)
        {
            var queueClient = Account.CreateCloudQueueClient();
            var queueReference = queueClient.GetQueueReference(queueName);

            await queueReference.CreateIfNotExistsAsync();
            await queueReference.AddMessageAsync(new CloudQueueMessage(message));
        }

        public async Task EnqueueMessage<T>(T message)
        {
            var serializeMessage = JsonConvert.SerializeObject(message);
            var queueClient = Account.CreateCloudQueueClient();
            var queueReference = queueClient.GetQueueReference(queueName);

            await queueReference.CreateIfNotExistsAsync();
            await queueReference.AddMessageAsync(new CloudQueueMessage(serializeMessage));
        }
    }
}