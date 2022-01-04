using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Products.MicroService.Data;
using Products.MicroService.Dtos;
using Products.MicroService.Models;

namespace Products.MicroService.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;
        private readonly IMapper mapper;

        public ProductController(IProductService service,IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ProductReadDto>> Get()
        {
            var products = service.GetData();

            return Ok(mapper.Map<List<ProductReadDto>>(products));
        }
        
        [HttpGet("{id}")]
        public ActionResult<ProductReadDto> Get(int id)
        {
            var product = service.GetProductById(id);
            return Ok(mapper.Map<ProductReadDto>(product)); 
        }
        
        [HttpPost]
        public void Post(ProductCreateDto pdt)
        {
            var product = mapper.Map<Product>(pdt);
            service.InsertProduct(product);
        }
        
        [HttpPut("{id}")]
        public void Put(ProductReadDto pdt)           
        {
            var product = mapper.Map<Product>(pdt);
            service.UpdateProduct(product);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.DeleteProductById(id);
        }
    }
}
