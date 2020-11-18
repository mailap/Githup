using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DrinkStores.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(   
                    new Product
                    {
                        Name = "Coffe",
                        Description = "The drink is very good quality",
                        Img= "https://media3.s-nbcnews.com/j/newscms/2019_33/2203981/171026-better-coffee-boost-se-329p_67dfb6820f7d3898b5486975903c2e51.fit-1240w.jpg ",
                        category ="mailap",
                        Price = 20,
                        Discount = 5,
                        Status = "The drink is very good quality"
                    },
                    new Product
                    {
                        Name = "Sinh Tố",
                        Description = "Sinh tố xoài",
                        Img = "https://cdn3.volusion.com/fqzgh.xmhmk/v/vspfiles/photos/FANTA-01-2.jpg?v-cache=1523337944",
                        category = "mailap",
                        Price = 25,
                        Discount = 10,
                        Status = "The drink is very good quality"
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "The drink is very good quality",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nbcnews.com%2Fbetter%2Flifestyle%2Fhow-tap-health-benefits-coffee-ncna1096031&psig=AOvVaw26svHkSxmpPxesjk7zvzhb&ust=1605806595727000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNCM0_DNjO0CFQAAAAAdAAAAABAD",
                        category = "mailap",
                        Price = 35,
                        Discount = 15,
                        Status = "The drink is very good quality"
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "The drink is very good quality",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nbcnews.com%2Fbetter%2Flifestyle%2Fhow-tap-health-benefits-coffee-ncna1096031&psig=AOvVaw26svHkSxmpPxesjk7zvzhb&ust=1605806595727000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNCM0_DNjO0CFQAAAAAdAAAAABAD",
                        category = "mailap",
                        Price = 30,
                        Discount = 20,
                        Status = "The drink is very good quality"
                    },
                    new Product
                    {
                        Name = "Kayak",
                        Description = "The drink is very good quality",
                        Img = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nbcnews.com%2Fbetter%2Flifestyle%2Fhow-tap-health-benefits-coffee-ncna1096031&psig=AOvVaw26svHkSxmpPxesjk7zvzhb&ust=1605806595727000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNCM0_DNjO0CFQAAAAAdAAAAABAD",
                        category = "mailap",
                        Price = 50,
                        Discount = 25 ,
                        Status = "The drink is very good quality"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
