namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class FeaturesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Features.Any())
            {
                return;
            }

            var features = new List<Feature>
            {
                new Feature { Name = "Auto Start Stop function", FeatureTypeId = 1 },
                new Feature { Name = "Bluetooth \\ handsfree system", FeatureTypeId = 1 },
                new Feature { Name = "DVD, TV", FeatureTypeId = 1 },
                new Feature { Name = "Steptronic, Tiptronic", FeatureTypeId = 1 },
                new Feature { Name = "USB, audio \\ video, IN \\ AUX outputs", FeatureTypeId = 1 },
                new Feature { Name = "Adaptive air suspension", FeatureTypeId = 1 },
                new Feature { Name = "Keyless ignition", FeatureTypeId = 1 },
                new Feature { Name = "Keyless ignition", FeatureTypeId = 1 },
                new Feature { Name = "Board computer", FeatureTypeId = 1 },
                new Feature { Name = "Fast \\ slow gears", FeatureTypeId = 1 },
                new Feature { Name = "Electric side mirrors", FeatureTypeId = 1 },
                new Feature { Name = "Electric windows", FeatureTypeId = 1 },
                new Feature { Name = "Electric suspension adjustment", FeatureTypeId = 1 },
                new Feature { Name = "Electric seat adjustment", FeatureTypeId = 1 },
                new Feature { Name = "Electric power steering", FeatureTypeId = 1 },
                new Feature { Name = "Air conditioning", FeatureTypeId = 1 },
                new Feature { Name = "Climatronic", FeatureTypeId = 1 },
                new Feature { Name = "Multifunction steering wheel", FeatureTypeId = 1 },
                new Feature { Name = "Navigation system", FeatureTypeId = 1 },
                new Feature { Name = "Steering wheel heating", FeatureTypeId = 1 },
                new Feature { Name = "Heated windshield", FeatureTypeId = 1 },
                new Feature { Name = "Electric heated seats", FeatureTypeId = 1 },
                new Feature { Name = "Steering wheel adjustment", FeatureTypeId = 1 },
                new Feature { Name = "Rain sensor", FeatureTypeId = 1 },
                new Feature { Name = "Power steering", FeatureTypeId = 1 },
                new Feature { Name = "Headlamp wash system", FeatureTypeId = 1 },
                new Feature { Name = "Speed ​​control system", FeatureTypeId = 1 },
                new Feature { Name = "Stereo", FeatureTypeId = 1 },
                new Feature { Name = "Refrigerator", FeatureTypeId = 1 },
                new Feature { Name = "GPS tracking system", FeatureTypeId = 2 },
                new Feature { Name = "Automatic stability control", FeatureTypeId = 2 },
                new Feature { Name = "Adaptive headlights", FeatureTypeId = 2 },
                new Feature { Name = "Anti-lock braking system", FeatureTypeId = 2 },
                new Feature { Name = "Airbags - Rear", FeatureTypeId = 2 },
                new Feature { Name = "Air bags - Front", FeatureTypeId = 2 },
                new Feature { Name = "Airbags - Side", FeatureTypeId = 2 },
                new Feature { Name = "Electronic brakeforce distribution", FeatureTypeId = 2 },
                new Feature { Name = "Electronic stabilization program", FeatureTypeId = 2 },
                new Feature { Name = "Tire pressure control", FeatureTypeId = 2 },
                new Feature { Name = "Parktronic", FeatureTypeId = 2 },
                new Feature { Name = "ISOFIX system", FeatureTypeId = 2 },
                new Feature { Name = "Dynamic stability system", FeatureTypeId = 2 },
                new Feature { Name = "Slip protection system", FeatureTypeId = 2 },
                new Feature { Name = "Brake drying system", FeatureTypeId = 2 },
                new Feature { Name = "Distance control system", FeatureTypeId = 2 },
                new Feature { Name = "Descent control system", FeatureTypeId = 2 },
                new Feature { Name = "Brake assist system", FeatureTypeId = 2 },
                new Feature { Name = "Alarm", FeatureTypeId = 3 },
                new Feature { Name = "Armored", FeatureTypeId = 3 },
                new Feature { Name = "Immobilizer", FeatureTypeId = 3 },
                new Feature { Name = "Reinforced glass", FeatureTypeId = 3 },
                new Feature { Name = "Power door locks", FeatureTypeId = 3 },
                new Feature { Name = "2(3) Doors", FeatureTypeId = 4 },
                new Feature { Name = "4(5) Doors", FeatureTypeId = 4 },
                new Feature { Name = "LED headlights", FeatureTypeId = 4 },
                new Feature { Name = "Xenon headlights", FeatureTypeId = 4 },
                new Feature { Name = "Alloy wheels", FeatureTypeId = 4 },
                new Feature { Name = "Heated wipers", FeatureTypeId = 4 },
                new Feature { Name = "Panoramic sunroof", FeatureTypeId = 4 },
                new Feature { Name = "Towbar", FeatureTypeId = 4 },
                new Feature { Name = "Halogen headlights", FeatureTypeId = 4 },
                new Feature { Name = "Ambient lighting", FeatureTypeId = 5 },
                new Feature { Name = "Massage seats", FeatureTypeId = 5 },
                new Feature { Name = "Paddle shifters", FeatureTypeId = 5 },
                new Feature { Name = "Leather", FeatureTypeId = 5 },
                new Feature { Name = "Cloth", FeatureTypeId = 5 },
                new Feature { Name = "Velour", FeatureTypeId = 5 },
                new Feature { Name = "4x4", FeatureTypeId = 6 },
                new Feature { Name = "7 seats", FeatureTypeId = 6 },
                new Feature { Name = "LPG", FeatureTypeId = 6 },
                new Feature { Name = "Long base", FeatureTypeId = 6 },
                new Feature { Name = "Short base", FeatureTypeId = 6 },
                new Feature { Name = "Leasing", FeatureTypeId = 6 },
                new Feature { Name = "Methane system", FeatureTypeId = 6 },
                new Feature { Name = "New importation", FeatureTypeId = 6 },
                new Feature { Name = "Full Service History", FeatureTypeId = 6 },
                new Feature { Name = "With registration", FeatureTypeId = 6 },
            };

            await dbContext.Features.AddRangeAsync(features);
        }
    }
}
