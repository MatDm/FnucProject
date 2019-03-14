using Fnuc.BLL.JsonModels;
using Fnuc.DAL;
using Fnuc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.Tools
{
    public class Convertor
    {
        private FnucDbContext db = new FnucDbContext();
        public ProductJson ConvertProductToProductJson(Product product)
        {
            var productCategory = db.Categories.Where(c => c.Id == product.CategoryId).FirstOrDefault();
            var productJson = new ProductJson()
            {
                id = product.Id,
                name = product.Name,
                description = product.Description,
                categoryId = product.CategoryId,
                price = product.Price,
                publicationDate = product.PublicationDate,
                category = productCategory.Name
            };
            return productJson;

        }


        public CategoryJson ConvertASingleCategoryToASingleCategoryJson(Category category)
        {
            var categoryJson = new CategoryJson()
            {
                id = category.Id,
                name = category.Name,
                subCategories = new List<Category>()
            };

            return categoryJson;
        }

        public List<CategoryJson> ConvertCategoryToCategoryJson(List<Category> categories)
        {
            var categoryJsonList = new List<CategoryJson>();
            foreach (var cat in categories)
            {
                var categoryJson = new CategoryJson()
                {
                    id = cat.Id,
                    name = cat.Name,
                    subCategories = GetSubCategories(cat)
                };
                categoryJsonList.Add(categoryJson);
            }
            

            return categoryJsonList;
        }

        public Category CategoryJsonToCategory(CategoryJson categoryJson)
        {
            return new Category()
            {
                Id = categoryJson.id,
                Name = categoryJson.name,
                ParentCategoryId = categoryJson.parentCategoryId
            };
        }

        private int? FindParentCategory(int id)
        {
            var Category = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            var ParentCategoryId = Category.ParentCategoryId;
            return ParentCategoryId;
        }

        private List<Category> GetSubCategories(Category category)
        {
            //var subCategories = db.Categories.Where(c => c.ParentCategoryId == category.Id).ToList();

            //return subCategories;
            var subCategoryList = new List<Category>();
           
            subCategoryList = FindChild(category);
            return subCategoryList;

        }

        private List<Category> FindChild(Category category)
        {
            return db.Categories.Where(c => c.ParentCategoryId == category.Id).ToList();
        }

        public Product ConvertProductJsonToProduct(ProductJson productJson)
        {
            
            var product = new Product()
            {
                Id = productJson.id,
                Name = productJson.name,
                Description = productJson.description,
                CategoryId = productJson.categoryId,
                Price = productJson.price,
                PublicationDate = productJson.publicationDate,
                StockQuantity = 1
            };
            return product;

        }

        public ShoppingCartJson ConvertToShoppingCartJson(ShoppingCart shoppingCart)
        {
            var shoppingCartJson = new ShoppingCartJson()
            {
                id = shoppingCart.id,
                userId = shoppingCart.userId,
                shoppingProducts = ConvertToShoppingProductJson(shoppingCart.shoppingProducts)
            };
            return shoppingCartJson;
        }

        public ShoppingProductJson ConvertToJson(ShoppingProduct shoppingProduct)
        {
            var shoppingProductJson = new ShoppingProductJson()
            {
                id = shoppingProduct.Id,
                name = shoppingProduct.Name,
                pricePerUnit = shoppingProduct.PricePerUnit,
                productId = shoppingProduct.ProductId,
                quantity = shoppingProduct.Quantity
            };

            return shoppingProductJson;
        }

        public List<ShoppingProductJson> ConvertToShoppingProductJson(List<ShoppingProduct> shoppingProducts)
        {
            var shoppingProductJsonList = new List<ShoppingProductJson>();
            foreach (var shoppingProduct in shoppingProducts)
            {
                shoppingProductJsonList.Add(ConvertToJson(shoppingProduct));
            }
            return shoppingProductJsonList;
        }
    }
}
