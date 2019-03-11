using Fnuc.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.JsonModels
{
    class CategoryJson
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Category> subCategories { get; set; }
    }
}
