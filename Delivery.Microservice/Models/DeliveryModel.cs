using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Microservice.Models
{
    public class DeliveryModel
    {
        public int orderId { get; set; }
        public int DateOrdered { get; set; }
        public bool isDelivered { get; set; }
        public int status { get; set; }
        public DateTime DateDelivered { get; set; }
    }
}
