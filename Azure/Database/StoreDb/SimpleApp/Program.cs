using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Microsoft.Win32;
using Microsoft.WindowsAzure;
using System.Collections.Generic;
using System.Linq;



using System.Threading;

using System.Configuration;


using DataLayer;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "vitaliiserver.database.windows.net";
                builder.UserID = "vitalii24";
                builder.Password = "asd123Q!";
                builder.InitialCatalog = "storeDb";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT  i.Name ");
                    sb.Append("FROM [Item]  as i ");

                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} ", reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
            
            //--------------------------Working  via   data  layer-------

            string connectionString = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
            Accessor con = new Accessor(connectionString);
 
            con.Add(new Item { Name = "Track" }).Wait();
            con.Delete(4).Wait();
            con.Delete(5).Wait();
            con.Update(6, new Item { Name = "CAR"}).Wait();

            Item[] items = con.GetAll().Result;

            foreach (Item i in items)
            {
                Console.WriteLine("ItemID =  {0},  ItemName = {1}",i.ItemId, i.Name);
            }

            Console.WriteLine("Completed");
            Console.ReadKey();
        }
    }
}
