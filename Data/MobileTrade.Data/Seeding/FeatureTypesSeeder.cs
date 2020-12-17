namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class FeatureTypesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.FeatureTypes.Any())
            {
                return;
            }

            var featureTypes = new List<FeatureType>
            {
                new FeatureType { Id = 1, Name = "Comfort" },
                new FeatureType { Id = 2, Name = "Safety" },
                new FeatureType { Id = 3, Name = "Security" },
                new FeatureType { Id = 4, Name = "Exterior" },
                new FeatureType { Id = 5, Name = "Interior" },
                new FeatureType { Id = 6, Name = "Other" },
            };

            await dbContext.FeatureTypes.AddRangeAsync(featureTypes);
        }
    }
}
