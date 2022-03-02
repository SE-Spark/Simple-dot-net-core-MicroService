using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Microservice.Models
{
    public class LocationModel
    {
        public string country { get; set; }
        public string city { get; set; }
        public string town { get; set; }
        public string estate { get; set; }
    }
}
