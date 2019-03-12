namespace Fnuc.DAL.Migrations
{
    using Fnuc.DAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
            //  to avoid creating duplicate seed data.
            Product product = new Product
            {
                Name = "Ikea gamer desk v2",
                Description = "Gamming desk",
                Price = 250,
                PublicationDate = DateTime.Now,
                StockQuantity = 5,
                CategoryId = 3,
            };

            context.Products.Add(product);

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
        }
    }
}
