using Fnuc.DAL.Entities;
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
    }
}
