using Microsoft.WindowsAzure.Storage;

namespace ImageResizeService
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