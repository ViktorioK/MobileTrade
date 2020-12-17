namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class FuelTypesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.FuelTypes.Any())
            {
                return;
            }

            var fuelTypes = new List<FuelType>
            {
                new FuelType { Name = "Petrol" },
                new FuelType { Name = "Diesel" },
                new FuelType { Name = "Hybrid" },
                new FuelType { Name = "Electric" },
            };

            await dbContext.FuelTypes.AddRangeAsync(fuelTypes);
        }
    }
}
