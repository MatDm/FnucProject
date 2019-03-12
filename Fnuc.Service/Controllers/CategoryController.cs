using Fnuc.BLL.JsonModels;
using Fnuc.BLL.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fnuc.Service.Controllers
{
    public class CategoryController : ApiController
    {
        CategoryLogic categoryLogic = new CategoryLogic();
        // GET: api/Category
        public List<CategoryJson> Get()
        {
            var categories = categoryLogic.GetAllCategories();
            return categories;
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
