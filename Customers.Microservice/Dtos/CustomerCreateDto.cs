using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Microservice.Dtos
{
    public class CustomerCreateDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public Int64 phoneNo { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
