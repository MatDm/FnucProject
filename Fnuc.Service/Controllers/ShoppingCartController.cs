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
    public class ShoppingCartController : ApiController
    {
        ShoppingCartLogic shoppingCartLogic = new ShoppingCartLogic();

        // GET: api/ShoppingCart
        public List<ShoppingCartJson> Get()
        {
            var result = new List<ShoppingCartJson>();

            result = shoppingCartLogic.GetAllShoppingCarts();
            return result;
            
        }

        // GET: api/ShoppingCart/5
        public ShoppingCartJson Get(int id)
        {
            var result = new ShoppingCartJson();
            result = shoppingCartLogic.Get(id);
            return result;
        }

        // POST: api/ShoppingCart
        [Route("api/shopping")]
        public void Post(ShoppingCartJson shoppingCartJson)
        {
            shoppingCartLogic.PostShoppingCart(shoppingCartJson);
        }

        // PUT: api/ShoppingCart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShoppingCart/5
        public void Delete(int id)
        {
        }
    }
}
