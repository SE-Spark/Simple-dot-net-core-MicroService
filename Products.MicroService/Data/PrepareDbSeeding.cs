using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Products.MicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.MicroService.Data
{
    public static class PrepareDbSeeding
    {
        public static void DataSeeding(IApplicationBuilder app)
        {
            using (var serviceScoped = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScoped.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext cxt)
        {
            if (!cxt.Products.Any())
            {
                Console.WriteLine("--------------->Seeding Data");
                cxt.Products.AddRange(
                    new Product { id = 1, prodName = "sukuma", category = "vegetables", cost = 50 },
                    new Product { id = 2, prodName = "kales", category = "vegetables", cost = 50 },
                    new Product { id = 3, prodName = "cabbage", category = "vegetables", cost = 150 },
                    new Product { id = 4, prodName = "spinach", category = "vegetables", cost = 70 },
                    new Product { id = 5, prodName = "tomatoes", category = "vegetables", cost = 30 },
                    new Product { id = 6, prodName = "onions", category = "vegetables", cost = 10 }
                    );
                cxt.SaveChanges();
            }
            else
            {
                Console.WriteLine("------------------------------|>data found");
            }
}
    }
}
