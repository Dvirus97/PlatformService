﻿using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext? context)
        {
            if (context == null) return;
            if (context.Platforms.Any())
            {
                Console.WriteLine("--> We already have data");
                return;
            }
            Console.WriteLine("--> Seeding data...");
            context.Platforms.AddRange(
                new Platform { Name = "Dot net", Publisher = "Microsoft", Cost = "Free" },
                new Platform { Name = "Sql Server Express", Publisher = "Microsoft", Cost = "Free" },
                new Platform { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }

            );

            context.SaveChanges();
        }
    }
}
