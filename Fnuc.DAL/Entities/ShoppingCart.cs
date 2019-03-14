using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.DAL.Entities
{
    public class ShoppingCart
    {
        public int id { get; set; }
        public int userId { get; set; }
        public List<ShoppingProduct> shoppingProducts { get; set; }
    }
}
