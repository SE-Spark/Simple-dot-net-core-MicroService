using Products.MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.MicroService.Data
{
    public interface IProductService
    {
        List<Product> GetData();
        Product GetProductById(int id);
        bool InsertProduct(Product pdt);
        bool UpdateProduct(Product pdt);
        bool DeleteProductById(int id);
    }
}
