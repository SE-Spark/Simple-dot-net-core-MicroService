using Customers.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Microservice.Data
{
    public interface ICustomerService
    {
        List<Customer> GetData();
        Customer GetCustomerById(int id);
        bool InsertCustomer(Customer ctr);
        bool UpdateCustomer(Customer ctr);
        bool DeleteCustomerById(int id);
        bool SaveChanges();
    }
}
