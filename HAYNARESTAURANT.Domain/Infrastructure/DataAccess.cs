using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYNARESTAURANT.Domain.Infrastructure
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(
                new HAYNARESTAURANT.Domain.Infrastructure.DataInitializer()
            );
        }

        public DbSet<Models.Users> User { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Products> Products { get; set; }
        public DbSet<Models.Delivery> Deliveries { get; set; }
        public DbSet< Models.Materials> Materials { get; set; }
        public DbSet<Models.DeliveryItems> DeliveryItem { get; set; }
    }
}
