using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Microservice.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public int productId { get; set; }
        public int quanty { get; set; }
    }
}
