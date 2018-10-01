using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;

namespace AzueStorageSetting
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new StorageCredentials("escaprism", "EnSOoWo2KNu7kuHLmPelbkIBq4rVa5VkRo9B+a5K1E4u3Rp+U8rcI/N3hed6VzXkR2eplAo8a4ddz14A1Ptz9Q==");
            var account = new CloudStorageAccount(credentials, true);
            var client = account.CreateCloudBlobClient();
            var existingProperties = client.GetServiceProperties();
            Console.WriteLine("Existing Service Version: " + existingProperties.DefaultServiceVersion);
            existingProperties.DefaultServiceVersion = "2018-03-28";
            client.SetServiceProperties(existingProperties);
            var updatedProperties = client.GetServiceProperties();
            Console.WriteLine("Updated Service Version: " + updatedProperties.DefaultServiceVersion);
            Console.ReadKey();
        }
    }
}
