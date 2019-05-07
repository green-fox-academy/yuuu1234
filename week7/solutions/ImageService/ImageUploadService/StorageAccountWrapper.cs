using Microsoft.WindowsAzure.Storage;

namespace ImageUploadService
{
    public class StorageAccountWrapper
    {
        public CloudStorageAccount Account { get; }

        public StorageAccountWrapper(string connectionString)
        {
            Account = CloudStorageAccount.Parse(connectionString);
        }
    }
}