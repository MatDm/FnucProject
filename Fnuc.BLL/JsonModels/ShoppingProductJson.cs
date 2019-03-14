using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.JsonModels
{
    public class ShoppingProductJson
    {
        public int id { get; set; }
        public string name { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public decimal pricePerUnit { get; set; }
    }
}
