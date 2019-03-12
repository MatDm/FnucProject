using Fnuc.BLL.JsonModels;
using Fnuc.DAL;
using Fnuc.DAL.Entities;
using Fnuc.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.get
{
    public class ProductLogic
    {
        private FnucDbContext db = new FnucDbContext();
        public List<Product> GetAllProducts()
        {
            var productRepository = new Repository<Product>(db);
            return productRepository.GetAll().ToList();
            
        }
    }
}
