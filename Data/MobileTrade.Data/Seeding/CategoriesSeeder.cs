namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<Category>
            {
                new Category { Name = "Van" },
                new Category { Name = "SUV" },
                new Category { Name = "Cabriolet" },
                new Category { Name = "Estate" },
                new Category { Name = "Coupe" },
                new Category { Name = "Minivan" },
                new Category { Name = "Pickup" },
                new Category { Name = "Saloon" },
                new Category { Name = "Stretch limousine" },
                new Category { Name = "Hatchback" },
            };

            await dbContext.Categories.AddRangeAsync(categories);
        }
    }
}
