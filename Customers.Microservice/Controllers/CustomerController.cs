using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Customers.Microservice.Data;
using Customers.Microservice.Dtos;
using Customers.Microservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Microservice.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        private readonly IMapper mapper;

        public CustomerController(ICustomerService service,IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<CustomerReadDto>> Get()
        {
            var customers = service.GetData();
            return Ok(mapper.Map<List<CustomerReadDto>>(customers));
        }
        
        [HttpGet("{id}")]
        public ActionResult<CustomerReadDto> Get(int id)
        {
            var customer = service.GetCustomerById(id);
            return Ok(mapper.Map<CustomerReadDto>(customer));
        }
        
        [HttpPost]
        public void Post(CustomerCreateDto ctr)
        {
            var customer = mapper.Map<Customer>(ctr);
            service.InsertCustomer(customer);
        }
        
        [HttpPut("{id}")]
        public void Put(CustomerReadDto ctr)
        {
            var customer = mapper.Map<Customer>(ctr);
            service.UpdateCustomer(customer);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.DeleteCustomerById(id);
        }
    }
}
