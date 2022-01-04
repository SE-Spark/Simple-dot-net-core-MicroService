using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.MicroService.Dtos
{
    public class ProductCreateDto
    {
        public string prodName { get; set; }
        public string category { get; set; }
        public decimal cost { get; set; }
    }
}
