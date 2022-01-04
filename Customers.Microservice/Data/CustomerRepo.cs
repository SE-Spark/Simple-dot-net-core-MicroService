using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Microservice.Models;
using Customers.MicroService.Data;

namespace Customers.Microservice.Data
{
    public class CustomerRepo : ICustomerService
    {
        private readonly AppDbContext context;

        public CustomerRepo(AppDbContext context)
        {
            this.context = context;
        }
        public bool DeleteCustomerById(int id)
        {
            var customer = context.Customers.Where(x => x.id == id).FirstOrDefault();
            if (customer == null)
                return false;
            context.Remove(customer);
            return SaveChanges();
        }

        public List<Customer> GetData()
        {
            return context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            var customer = context.Customers.Where(x => x.id == id).FirstOrDefault();
            if (customer == null)
                return new Customer();
            return customer;
        }

        public bool InsertCustomer(Customer ctr)
        {
            var customer = context.Customers.Where(x => x.id == ctr.id).FirstOrDefault();
            if (customer == null)
                return false;
            customer.firstName = ctr.firstName;
            customer.lastName = ctr.lastName;
            customer.email = ctr.email;
            customer.phoneNo = ctr.phoneNo;
            customer.city = ctr.city;
            customer.country = ctr.country;
            context.Add(customer);
            return SaveChanges();
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public bool UpdateCustomer(Customer ctr)
        {
            var customer = context.Customers.Where(x => x.id == ctr.id).FirstOrDefault();
            if (customer == null)
                return false;
            customer.firstName = ctr.firstName;
            customer.lastName = ctr.lastName;
            customer.email = ctr.email;
            customer.phoneNo = ctr.phoneNo;
            customer.city = ctr.city;
            customer.country = ctr.country;
            context.Update(customer);
            return SaveChanges();
        }
    }
}
