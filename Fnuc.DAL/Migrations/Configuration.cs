namespace Fnuc.DAL.Migrations
{
    using Fnuc.DAL.Entities;
    using System;
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
                Name = "keyboard",
                Description = "Razor Keyboard v3",
                Price = 50,
                PublicationDate = DateTime.Now,
                StockQuantity = 15,
                CategoryId = 3,
            };

            context.Products.Add(product);

        }
    }
}
