﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnuc.DAL.Entities
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Password { get; set; }

    }

}