﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.BLL.JsonModels
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<ShoppingProductJson> Products { get; set; }

    }
}