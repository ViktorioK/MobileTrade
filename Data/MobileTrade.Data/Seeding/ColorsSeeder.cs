namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class ColorsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Colors.Any())
            {
                return;
            }

            var colors = new List<Color>
            {
                new Color { Name = "Beige" },
                new Color { Name = "Black" },
                new Color { Name = "Blue" },
                new Color { Name = "Brown" },
                new Color { Name = "Gold" },
                new Color { Name = "Green" },
                new Color { Name = "Grey" },
                new Color { Name = "Orange" },
                new Color { Name = "Purple" },
                new Color { Name = "Red" },
                new Color { Name = "Silver" },
                new Color { Name = "White" },
                new Color { Name = "Yellow" },
                new Color { Name = "Metallic" },
            };

            await dbContext.Colors.AddRangeAsync(colors);
        }
    }
}
