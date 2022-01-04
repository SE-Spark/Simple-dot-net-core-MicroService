using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Customers.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.MicroService.Data
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
            if (!cxt.Customers.Any())
            {
                Console.WriteLine("--------------->Seeding Data");
                cxt.Customers.AddRange(
                        new Customer { id = 1, firstName = "Samy", lastName = "Justus", email = "samy@gmail.com", phoneNo = 789897569, city = "Nairobi", country = "Kenya" },
                        new Customer { id = 2, firstName = "Deno", lastName = "Justus", email = "deno@gmail.com", phoneNo = 789897569, city = "Eldoret", country = "Kenya" },
                        new Customer { id = 3, firstName = "keli", lastName = "Justus", email = "keli@gmail.com", phoneNo = 789897569, city = "Mombasa", country = "Kenya" }                        
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
