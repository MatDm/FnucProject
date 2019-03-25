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
using System.Web.Http.Cors;
using Fnuc.Service.Filters;

namespace Fnuc.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [IdentityBasicAuthentication]
    [Authorize]
    public class ProductController : ApiController
    {
        ProductLogic productLogic = new ProductLogic();
        
        // GET: api/Product ---- retrieve tous les produits
        [Route("api/product/all")]
        [ResponseType(typeof(List<ProductJson>))]
        public List<ProductJson> Get()
        {           
            var products = productLogic.GetAllProducts();
            return products;
        }

        [Route("api/product")]
        [ResponseType(typeof(List<ProductJson>))]
        public List<ProductJson> GetFlat()
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

        //GET : api/category/
        [Route("api/product/category/{id}")]
        public List<ProductJson> GetProductByCategory(int id)
        {
            var productList = productLogic.GetProductListById(id);
            return productList;
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
