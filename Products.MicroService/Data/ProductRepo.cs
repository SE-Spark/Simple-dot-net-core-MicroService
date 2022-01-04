using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.MicroService.Models;

namespace Products.MicroService.Data
{
    public class ProductRepo : IProductService
    {
        private readonly AppDbContext context;

        public ProductRepo(AppDbContext context)
        {
            this.context = context;
        }
        public bool DeleteProductById(int id)
        {
            var product = context.Products.Where(x => x.id == id).FirstOrDefault();
            if (product == null)
                return false;
            context.Products.Remove(product);
            return context.SaveChanges()>0;
        }

        public List<Product> GetData()
        {
            return context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            var product = context.Products.Where(x => x.id == id).FirstOrDefault();
            if (product == null)
                return new Product();
            return product;
        }

        public bool InsertProduct(Product pdt)
        {
            context.Products.Add(pdt);
            return context.SaveChanges() > 0;
        }

        public bool UpdateProduct(Product pdt)
        {
            var product = context.Products.Where(x => x.id == pdt.id).FirstOrDefault();
            if (product == null)
                return false;
            product.prodName = pdt.prodName;
            product.category = pdt.category;
            product.cost = pdt.cost;
            context.Products.Update(product);
            return context.SaveChanges() > 0;
        }
    }
}
