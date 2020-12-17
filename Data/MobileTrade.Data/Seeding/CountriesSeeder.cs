namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class CountriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Countries.Any())
            {
                return;
            }

            var countries = new List<Country>
            {
                new Country { Name = "Albania" },
                new Country { Name = "Andorra" },
                new Country { Name = "Austria" },
                new Country { Name = "Belarus" },
                new Country { Name = "Belgium" },
                new Country { Name = "Bosnia and Herzegovina" },
                new Country { Name = "Brazil" },
                new Country { Name = "Bulgaria" },
                new Country { Name = "Canada" },
                new Country { Name = "Croatia" },
                new Country { Name = "Cyprus" },
                new Country { Name = "Czech Republic" },
                new Country { Name = "Denmark" },
                new Country { Name = "Egypt" },
                new Country { Name = "Estonia" },
                new Country { Name = "Ethiopia" },
                new Country { Name = "Faroe Islands" },
                new Country { Name = "Finland" },
                new Country { Name = "France" },
                new Country { Name = "Germany" },
                new Country { Name = "Greece" },
                new Country { Name = "Hungary" },
                new Country { Name = "Iceland" },
                new Country { Name = "Ireland" },
                new Country { Name = "Israel" },
                new Country { Name = "Italy" },
                new Country { Name = "Japan" },
                new Country { Name = "Jordan" },
                new Country { Name = "Kuwait" },
                new Country { Name = "Latvia" },
                new Country { Name = "Lebanon" },
                new Country { Name = "Liechtenstein" },
                new Country { Name = "Lithuania" },
                new Country { Name = "Luxembourg" },
                new Country { Name = "Macedonia" },
                new Country { Name = "Malta" },
                new Country { Name = "Mexico" },
                new Country { Name = "Moldova" },
                new Country { Name = "Monaco" },
                new Country { Name = "Montenegro" },
                new Country { Name = "Morocco" },
                new Country { Name = "Netherlands" },
                new Country { Name = "New Zealand" },
                new Country { Name = "Nigeria" },
                new Country { Name = "Norway" },
                new Country { Name = "Oman" },
                new Country { Name = "Poland" },
                new Country { Name = "Portugal" },
                new Country { Name = "Romania" },
                new Country { Name = "Russian Federation" },
                new Country { Name = "San Marino" },
                new Country { Name = "Saudi Arabia" },
                new Country { Name = "Serbia" },
                new Country { Name = "Slovakia" },
                new Country { Name = "Slovenia" },
                new Country { Name = "South Africa" },
                new Country { Name = "South Korea" },
                new Country { Name = "Spain" },
                new Country { Name = "Sweden" },
                new Country { Name = "Switzerland" },
                new Country { Name = "Taiwan" },
                new Country { Name = "Tunisia" },
                new Country { Name = "Turkey" },
                new Country { Name = "Ukraine" },
                new Country { Name = "United Arab Emirates" },
                new Country { Name = "United Kingdom" },
                new Country { Name = "USA" },
            };

            await dbContext.Countries.AddRangeAsync(countries);
        }
    }
}
