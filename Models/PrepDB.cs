using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace ColourAPI.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ColourContext>());
            }
        }
        
        public static void SeedData(ColourContext context)
        {
            System.Console.WriteLine("Appling migrations ...");

            // if(!context.ColourItems.Any())
            // {
            //     System.Console.WriteLine("Adding data. Seeding.");  

            //     context.ColourItems.AddRange(
            //         new Colour(){ColourName = "Red"},
            //         new Colour(){ColourName = "Blue"},
            //         new Colour(){ColourName = "White"},
            //         new Colour(){ColourName = "Yellow"},
            //         new Colour(){ColourName = "Pink"}
            //     );
            //     context.SaveChanges();
            // }
            // else
            // {
            //     System.Console.WriteLine("Already have data. Not seeding.");
            // }
        }
    }
}