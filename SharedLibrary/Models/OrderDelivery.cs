using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class OrderDelivery
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public int productId { get; set; }
        public int quanty { get; set; }
    }
}
