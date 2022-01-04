﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.MicroService.Models
{
    public class Product
    {
        public int id { get; set; }
        public string prodName { get; set; }
        public string category { get; set; }
        public decimal cost { get; set; }
    }
}
