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
    public class ShoppingCartLogic
    {
        Convertor convertor = new Convertor();
        private FnucDbContext db = new FnucDbContext();

        public List<ShoppingCartJson> GetAllShoppingCarts()
        {
            Repository<ShoppingCart> shoppingCartRepository = new Repository<ShoppingCart>(db);
            var shoppingCartList = shoppingCartRepository.GetAll().ToList();
            var shoppingCartJsonList = new List<ShoppingCartJson>();
            //ajouter la logique qui remplit les shoppingproduct via l'id de la shoppingcart
            

            foreach (var shoppingCart in shoppingCartList)
            {
                //récuperer les shoppingProducts
                shoppingCart.ShoppingProducts = GetShoppingProductList(shoppingCart);
                // convertir en shoppingCatjson et ajoutez à la liste
                shoppingCartJsonList.Add(convertor.ConvertToShoppingCartJson(shoppingCart));
            }
            return shoppingCartJsonList;
        }

        public void PostShoppingCart(ShoppingCartJson shoppingCartJson)
        {
            Repository<ShoppingCart> shoppingCartRepository = new Repository<ShoppingCart>(db);
            var shoppingCart = convertor.ConvertToShoppingCart(shoppingCartJson);
            shoppingCartRepository.Insert(shoppingCart);
            db.SaveChanges();
        }

        public ShoppingCartJson Get(int id)
        {
            Repository<ShoppingCart> shoppingCartRepository = new Repository<ShoppingCart>(db);
            var shoppingCart = shoppingCartRepository.GetById(id);
            shoppingCart.ShoppingProducts = GetShoppingProductList(shoppingCart);
            return convertor.ConvertToShoppingCartJson(shoppingCart);
        }

        public List<ShoppingProduct> GetShoppingProductList(ShoppingCart shoppingCart)
        {
            var shoppingProductList = new List<ShoppingProduct>();
            shoppingProductList = db.ShoppingProducts.Where(s => s.ShoppingCartId == shoppingCart.Id).ToList();
            return shoppingProductList;
        }



    }
}
