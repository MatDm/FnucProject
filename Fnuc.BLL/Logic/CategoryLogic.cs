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
    public class CategoryLogic
    {
        Convertor convertor = new Convertor();
        private FnucDbContext db = new FnucDbContext();
        public List<CategoryJson> GetAllCategories()
        {
            Repository<Category> categoryRepository = new Repository<Category>(db);
            //var categoryList = categoryRepository.GetAll().ToList();
            //var categoryJsonList = new List<CategoryJson>();

            //foreach (var category in categoryList)
            //{
            //    var categoryJson = convertor.ConvertCategoryToCategoryJson(category);
            //    categoryJsonList.Add(categoryJson);
            //}

            //return categoryJsonList;
            var rootCategory = db.Categories.Where(c => c.ParentCategoryId == null).ToList();
            var result = convertor.ConvertCategoryToCategoryJson(rootCategory);
            return result;

        }

        public void Delete(int id)
        {
            Repository<Category> categoryRepository = new Repository<Category>(db);
            var category = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            categoryRepository.Delete(category);
            db.SaveChanges();

        }

        public void Update(CategoryJson categoryJson)
        {
            var categoryToUpdate = db.Categories.Where(c => c.Id == categoryJson.id).SingleOrDefault();
            AssignValue(categoryJson, categoryToUpdate);
            db.SaveChanges();
        }

        private void AssignValue(CategoryJson categoryJson, Category categoryToUpdate)
        {
            categoryToUpdate.Name = categoryJson.name;
            categoryToUpdate.ParentCategoryId = categoryJson.parentCategoryId;          
        }

        public void Post(CategoryJson categoryJson)
        {
            Repository<Category> categoryRepository = new Repository<Category>(db);
            var category = convertor.CategoryJsonToCategory(categoryJson);
            categoryRepository.Insert(category);
            db.SaveChanges();
        }

        public CategoryJson Get(int id)
        {
            Repository<Category> categoryRepository = new Repository<Category>(db);
            var category = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            var categoryJson = convertor.ConvertASingleCategoryToASingleCategoryJson(category);
            return categoryJson;
        }
    }
}
