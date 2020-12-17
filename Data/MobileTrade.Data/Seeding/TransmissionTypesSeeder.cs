namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class TransmissionTypesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.TransmissionTypes.Any())
            {
                return;
            }

            var transmissionTypes = new List<TransmissionType>
            {
                new TransmissionType { Name = "Manual" },
                new TransmissionType { Name = "Automatic" },
                new TransmissionType { Name = "Semi-automatic" },
            };

            await dbContext.TransmissionTypes.AddRangeAsync(transmissionTypes);
        }
    }
}
