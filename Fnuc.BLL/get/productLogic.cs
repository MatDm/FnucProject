using Fnuc.BLL.JsonModels;
using Fnuc.BLL.Tools;
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
        
        Convertor convertor = new Convertor();
        private FnucDbContext db = new FnucDbContext();
        
        public List<ProductJson> GetAllProducts()
        {
            Repository<Product> productRepository = new Repository<Product>(db);

            var productList = productRepository.GetAll().ToList();
           
            var productJsonList = new List<ProductJson>();

            foreach (var product in productList)
            {
                var jsonProduct = convertor.ConvertProductToProductJson(product);
                productJsonList.Add(jsonProduct);
            }
            return productJsonList;
            
        }

        public void PostProduct(ProductJson productJson)
        {
            Repository<Product> productRepository = new Repository<Product>(db);
            var product = convertor.ConvertProductJsonToProduct(productJson);
            productRepository.Insert(product);
            db.SaveChanges();
        }

        public ProductJson GetProduct(int id)
        {
            Repository<Product> productRepository = new Repository<Product>(db);

            var product = productRepository.GetById(id);
            return convertor.ConvertProductToProductJson(product);
        }


    }
}
