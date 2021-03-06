﻿using Fnuc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.DAL
{
    public class FnucDbContext : DbContext
    {
        public FnucDbContext() : base("name = FnucDbContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingProduct> ShoppingProducts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasOptional(e => e.ParentCategory).WithMany().HasForeignKey(m => m.ParentCategoryId);
        }

    }
}
