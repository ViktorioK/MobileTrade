namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class EmissionClassesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.EmissionClasses.Any())
            {
                return;
            }

            var emissionClasses = new List<EmissionClass>
            {
                new EmissionClass { Name = "Euro1" },
                new EmissionClass { Name = "Euro2" },
                new EmissionClass { Name = "Euro3" },
                new EmissionClass { Name = "Euro4" },
                new EmissionClass { Name = "Euro5" },
                new EmissionClass { Name = "Euro6" },
            };

            await dbContext.EmissionClasses.AddRangeAsync(emissionClasses);
        }
    }
}
