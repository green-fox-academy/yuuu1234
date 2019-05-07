using System.Threading.Tasks;

namespace ImageUploadService.Services
{
    public interface IMessageQueueService
    {
        Task EnqueueMessage(string message);
        Task EnqueueMessage<T>(T message);
    }
}