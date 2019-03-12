using Fnuc.BLL.get;
using Fnuc.BLL.JsonModels;
using Fnuc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Fnuc.Service.Controllers
{
    public class ProductController : ApiController
    {
        //private FnucDbContext db = new FnucDbContext();
        // GET: api/Product ---- retrieve tous les produits
        [ResponseType(typeof(List<Product>))]
        public List<Product> GetProducts()
        {
            ProductLogic productLogic = new ProductLogic();
            var products = productLogic.GetAllProducts();
            return products;
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
