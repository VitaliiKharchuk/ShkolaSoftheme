using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Collections.Generic;
using System.Linq;


using Microsoft.WindowsAzure.Storage.RetryPolicies;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading;

namespace Tables
{
    class Program
    {
        private const string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=vitalii;AccountKey=+8rWOE1mvYVuW8/TKJ8PbNK0yZ3ojszOd502p61qLiKug7zbNQ/7A9WQHCcz7gSlowRp4nbATMqbrycw+9yAwA==;EndpointSuffix=core.windows.net";

        private const string ContainerName = "my-container";

        static void Main(string[] args)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConnectionString);

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            CloudTable cloudTable = tableClient.GetTableReference("Tourists");

            cloudTable.ExecuteBatch(new TableBatchOperation()
            {
                 TableOperation.InsertOrReplace(new TouristEntity("New York", "1")
                 {
                     Custumer = "Watson",
                     Details = "skyskrapers"
                 }),

                 TableOperation.InsertOrReplace(new TouristEntity("New York", "3")
                 {
                     Custumer = "Gregson",
                     Details = "police  office"
                 })
            });




            List<TouristEntity> listReviewsByPoint  = cloudTable.CreateQuery<TouristEntity>()
                .Where( x => x.PartitionKey == "New York").ToList();


            
            List<TouristEntity> listReviewsByCustumer = cloudTable.CreateQuery<TouristEntity>()
                .Where(x => x.PartitionKey == "Manchester" && x.Custumer == "Bob").ToList();

            List<TouristEntity> listDetailsOfOneRewiew = cloudTable.CreateQuery<TouristEntity>()
                .Where(x => x.PartitionKey == "London" && x.RowKey == "0").ToList();
            




            foreach (var  t in listReviewsByPoint)
            {
                Console.WriteLine(t.Custumer);
            }
            


            Console.WriteLine("Completed");
            Console.ReadLine();
        }
    }

    public class TouristEntity : TableEntity
    {
        public TouristEntity() { }

        public TouristEntity(string city, string touristIndex)
        {
            this.PartitionKey = city;
            this.RowKey = touristIndex;
        }

        public string Custumer { get; set; }
        public string Details { get; set; }


        public override string ToString() => $"{Custumer}, {Details}";
        

    }
}
