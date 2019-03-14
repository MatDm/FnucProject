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

namespace Fnuc.BLL.Logic
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

        public List<ProductJson> GetProductListById(int id)
        {
            Repository<Product> productRepository = new Repository<Product>(db);
            var category = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            var productList = db.Products.Where(p => p.CategoryId == category.Id).ToList();
            var productListJson = new List<ProductJson>();
            foreach (var product in productList)
            {
                var productJson = convertor.ConvertProductToProductJson(product);
                productListJson.Add(productJson);
            }
            return productListJson;
        }

        public List<ProductJson> GetProductListByCategoryName(string categoryName)
        {
            Repository<Product> productRepository = new Repository<Product>(db);
            var category = db.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            var productList = db.Products.Where(p => p.CategoryId == category.Id).ToList();
            var productListJson = new List<ProductJson>();
            foreach (var product in productList)
            {
                var productJson = convertor.ConvertProductToProductJson(product);
                productListJson.Add(productJson);
            }
            return productListJson;
        }

        public void DeleteProd(int id)
        {
            Repository<Product> productRepository = new Repository<Product>(db);
            var product = productRepository.GetById(id);
            productRepository.Delete(product);
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
