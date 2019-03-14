using Fnuc.BLL.Logic;
using Fnuc.BLL.JsonModels;
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
        ProductLogic productLogic = new ProductLogic();
        
        // GET: api/Product ---- retrieve tous les produits
        [ResponseType(typeof(List<ProductJson>))]
        public List<ProductJson> Get()
        {           
            var products = productLogic.GetAllProducts();
            return products;
        }

        // GET: api/Product/5
        public ProductJson Get(int id)
        {
            var product = productLogic.GetProduct(id);
            return product;
        }

        // POST: api/Product
        public void Post(ProductJson productJson)
        {

            productLogic.PostProduct(productJson);
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            productLogic.DeleteProd(id);
        }
    }
}
