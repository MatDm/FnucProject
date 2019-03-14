using Fnuc.BLL.JsonModels;
using Fnuc.BLL.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Fnuc.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoryController : ApiController
    {
        CategoryLogic categoryLogic = new CategoryLogic();
        // GET: api/Category
        [Route("api/category/all")]
        public List<CategoryJson> Get()
        {
            var categories = categoryLogic.GetAllCategories();
            return categories;
        }

        // GET: api/Category/5
        public CategoryJson Get(int id)
        {
            var categoryJson = categoryLogic.Get(id);
            return categoryJson;
        }

        // POST: api/Category
        public void Post(CategoryJson categoryJson)
        {
            categoryLogic.Post(categoryJson);
        }

        // PUT: api/Category/5
        public void Put(CategoryJson categoryJson)
        {
            categoryLogic.Update(categoryJson);
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
            categoryLogic.Delete(id);
        }
    }
}
