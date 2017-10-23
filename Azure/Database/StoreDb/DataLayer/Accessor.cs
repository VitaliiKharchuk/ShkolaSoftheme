using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DataLayer
{
    public class Accessor
    {
        private string connectionString;
        
        public   Accessor (string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task Add(Item item)
        {
            using (var context = new Connection(connectionString))
            {
                context.Items.Add(item);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(int ItemId)
        {
            using (var context = new Connection(connectionString))
            {
                Item item = context.Items.Where(i => i.ItemId == ItemId).FirstOrDefault();


                if (item != null)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                await context.SaveChangesAsync();
            }
        }


        public async Task Update(int itemId, Item  item)
        {
            using (var context = new  Connection(connectionString))
            {
                Item OldItem = context.Items.Where(i => i.ItemId == itemId).FirstOrDefault();

                if (OldItem != null)
                {
                    OldItem.Name = item.Name;
                    context.Entry(OldItem).State = EntityState.Modified;
                }

                await context.SaveChangesAsync();
            }
        }

        public async Task<Item[]> GetAll()
        {
            using (var context = new  Connection(connectionString))
            {
                return await context.Items.ToArrayAsync();
            }
        }



      

        /*
         * 
         * 
         * 
         * 
         * 
          using (var context = new FirstAzureDbContext(_connectionString))
           {
             context.UserTables.Add(user);
             context.SaveChangesAsync();
           }
        */
    }
}
