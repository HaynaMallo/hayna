using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HAYNARESTAURANT.Domain.BBL;
using HAYNARESTAURANT.Domain.Infrastructure;
using HAYNARESTAURANT.Domain.Models;
using HAYNARESTAURANT.Domain.Models.Enums;

namespace HAYNARESTAURANT.Domain.Infrastructure
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
    {
        protected override void Seed(DataAccess db)
        {
            #region Users
            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Hayna",
                    LastName = "Mallo",
                    Password = "Hayna01",
                    UserName = "HynMallo",
                    Role = Models.Enums.Role.Admin
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Shaine",
                    LastName = "Maravillo",
                    Password = "Shaine02",
                    UserName = "Shaine",
                    Role = Models.Enums.Role.Admin
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Allan",
                    LastName = "Novalta",
                    Password = "Allan03",
                    UserName = "Allan",
                    Role = Models.Enums.Role.Cashier
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Ticar",
                    Password = "Ticar04",
                    UserName = "Jane",
                    Role = Models.Enums.Role.Cashier
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Goshen",
                    LastName = "Jimenez",
                    Password = "Goshen05",
                    UserName = "SirGosh",
                    Role = Models.Enums.Role.Chef
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "theresa",
                    LastName = "Jimenez",
                    Password = "theresa06",
                    UserName = "MaamThere",
                    Role = Models.Enums.Role.Chef
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Wendhel",
                    LastName = "Aton",
                    Password = "Wendhel07",
                    UserName = "Wendhel",
                    Role = Models.Enums.Role.InventoryController
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Lorzon",
                    LastName = "Dahunan",
                    Password = "Lorzon08",
                    UserName = "Lorzon08",
                    Role = Models.Enums.Role.InventoryController
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Nissan",
                    LastName = "Casapunan",
                    Password = "Nissan09",
                    UserName = "Nissan",
                    Role = Models.Enums.Role.Waiter
                }
            );
            db.SaveChanges();

            db.User.Add(
                new Models.Users()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Larich",
                    LastName = "Morales",
                    Password = "Larich10",
                    UserName = "Larich",
                    Role = Models.Enums.Role.Waiter
                }
            );
            db.SaveChanges();
            #endregion

            #region Categories
            db.Categories.Add(
                new Models.Category()
                {
                    Id = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac0"),
                    Name = "Beverages"
                }
            );
            db.SaveChanges();

            db.Categories.Add(
                new Models.Category()
                {
                    Id = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Name = "Alcoholic",
                    ParentId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac0")
                }
            );
            db.SaveChanges();

            db.Categories.Add(
                new Models.Category()
                {
                    Id = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Name = "Non-alcoholic",
                    ParentId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac0")
                }
            );
            db.SaveChanges();
            #endregion

            #region Products
            db.Products.Add(
                new Models.Products()
                {
                    Id = Guid.NewGuid(),
                    Name = "Beer",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Price = decimal.Parse("50")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Products()
                {
                    Id = Guid.NewGuid(),
                    Name = "Rhum",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Price = decimal.Parse("750")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Products()
                {
                    Id = Guid.NewGuid(),
                    Name = "Whiskey",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Price = decimal.Parse("550")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Products()
                {
                    Id = Guid.NewGuid(),
                    Name = "Juice",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Price = decimal.Parse("50")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Products()
                {
                    Id = Guid.NewGuid(),
                    Name = "Soda",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Price = decimal.Parse("40")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Products()
                {
                    Id = Guid.NewGuid(),
                    Name = "Shake",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Price = decimal.Parse("80")
                }
            );
            db.SaveChanges();
            #endregion
            #region Materials
            db.Materials.Add(new Models.Materials()
            {
                Id = Guid.NewGuid(),
                Name = "Chicken Fillet",
                UOM = "pcs",
                Quantity = 50

            }
            );
            db.SaveChanges();

            db.Materials.Add(new Models.Materials()
            {
                Id = Guid.NewGuid(),
                Name = "Noodles",
                UOM = "packs",
                Quantity = 50

            }
           );
            db.SaveChanges();

            db.Materials.Add(new Models.Materials()
            {
                Id = Guid.NewGuid(),
                Name = "siomai",
                UOM = "pcs",
                Quantity = 100

            }
           );
            db.SaveChanges();


            #endregion
        }
    }
}
