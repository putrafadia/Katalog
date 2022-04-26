using KatalogProduk.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogProduk.Data
{
    public class PrebDb
    {

        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateAsyncScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<KatalogProdukContext>());
            }
        }

        private static void SeedData(KatalogProdukContext context)
        {
           
            if (!context.Categories.Any())
            {
                Console.WriteLine("--> Seeding Data...");
                context.Categories.AddRange(
                    new Category { Name = "Pria"},
                    new Category { Name = "Wanita" },
                    new Category { Name ="Anak-Anak"}
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Data Platforms sudah ada..");
            }
        }
    }
}
