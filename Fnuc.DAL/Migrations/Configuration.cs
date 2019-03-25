namespace Fnuc.DAL.Migrations
{
    using Fnuc.DAL.Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Fnuc.DAL.FnucDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Fnuc.DAL.FnucDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data.
            //Product product = new Product
            //{
            //    Name = "Ikea gamer desk v2",
            //    Description = "Gamming desk",
            //    Price = 250,
            //    PublicationDate = DateTime.Now,
            //    StockQuantity = 5,
            //    CategoryId = 3,
            //};

            //context.Products.Add(product);

            //var categories = new List<Category>()
            //{        
            //    new Category {Id = 1, Name = "furniture", ParentCategoryId=null },
            //    new Category {Id = 2, Name = "desk", ParentCategoryId=1 },
            //    new Category {Id = 3, Name = "gamer desk", ParentCategoryId=2}
            //};  

            //var categories = new List<Category>()
            //{
            //    new Category {Name = "chair", ParentCategoryId=1 },
            //    new Category {Name = "storage", ParentCategoryId=1 },
            //    new Category {Name = "table", ParentCategoryId=1}
            //};

            //categories.ForEach(c => context.Categories.Add(c));
            //context.SaveChanges();

            //var shoppingProductListA = new List<ShoppingProduct>()
            //{
            //    new ShoppingProduct {Name = "Razor Mouse", PricePerUnit = 50, ProductId = 15, Quantity = 2 },
            //    new ShoppingProduct {Name = "Razor MousePad", PricePerUnit = 20, ProductId = 17, Quantity = 1}
            //};

            //var shoppingProductListB = new List<ShoppingProduct>()
            //{
            //    new ShoppingProduct {Name = "Razor keyboard", PricePerUnit = 75, ProductId = 8, Quantity = 1 },
            //    new ShoppingProduct {Name = "Razor headset", PricePerUnit = 85, ProductId = 27, Quantity = 1}
            //};


            //var shoppingCartList = new List<ShoppingCart>()
            //{
            //    new ShoppingCart {userId = 1, shoppingProducts = shoppingProductListA},
            //    new ShoppingCart {userId = 2, shoppingProducts =  shoppingProductListB}
            //};

            //shoppingCartList.ForEach(s => context.ShoppingCarts.Add(s));

            //var users = new List<User>()
            //{
            //    new User {Name = "jonh", Password = "password"},
            //    new User {Name = "mat", Password = "james"}
            //};

            //users.ForEach(u => context.Users.Add(u));
            //context.SaveChanges();
        }
    }
}
