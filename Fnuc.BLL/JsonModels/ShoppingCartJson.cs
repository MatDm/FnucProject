﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.JsonModels
{
    public class ShoppingCartJson
    {
        public int id { get; set; }
        public int userId { get; set; }
        public List<ShoppingProductJson> shoppingProducts { get; set; }
    }
}
