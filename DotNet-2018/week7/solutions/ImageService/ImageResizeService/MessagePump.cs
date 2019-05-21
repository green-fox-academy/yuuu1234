using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Queue;

namespace ImageResizeService
{
    internal class MessagePump
    {
        private readonly StorageAccountWrapper accountWrapper;
        private readonly string queueName;

        public MessagePump(StorageAccountWrapper storageAccountWrapper, string queueName = "imagequeue")
        {
            accountWrapper = storageAccountWrapper;
            this.queueName = queueName;
        }

        public async Task Do(CancellationToken cancellationToken, Func<CloudQueueMessage, Task> callback)
        {
            var queueClient = accountWrapper.Account.CreateCloudQueueClient();
            var queueReference = queueClient.GetQueueReference(queueName);

            await queueReference.CreateIfNotExistsAsync(cancellationToken);

            while (!cancellationToken.IsCancellationRequested)
            {
                var message = queueReference.GetMessage();

                if (message == null)
                {
                    await Task.Delay(2000, cancellationToken);
                    continue;
                }

                await callback(message);

                await queueReference.DeleteMessageAsync(message);
            }
        }
    }
}