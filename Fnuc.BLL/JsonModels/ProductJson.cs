using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.JsonModels
{
    public class ProductJson
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public DateTime publicationDate { get; set; }
    }
}
