namespace MobileTrade.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MobileTrade.Data.Models;

    public class MakesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Makes.Any())
            {
                return;
            }

            var makes = new List<Make>
            {
                new Make { Id = 1, Name = "Abarth" },
                new Make { Id = 2, Name = "AC" },
                new Make { Id = 3, Name = "Acura" },
                new Make { Id = 4, Name = "Aixam" },
                new Make { Id = 5, Name = "Alfa Romeo" },
                new Make { Id = 6, Name = "Alpina" },
                new Make { Id = 7, Name = "Asia Motors" },
                new Make { Id = 8, Name = "Aston Martin" },
                new Make { Id = 9, Name = "Audi" },
                new Make { Id = 10, Name = "Austin" },
                new Make { Id = 11, Name = "Bentley" },
                new Make { Id = 12, Name = "BMW" },
                new Make { Id = 13, Name = "Borgward" },
                new Make { Id = 14, Name = "Brilliace" },
                new Make { Id = 15, Name = "Bugatti" },
                new Make { Id = 16, Name = "Buick" },
                new Make { Id = 17, Name = "Cadillac" },
                new Make { Id = 18, Name = "Chevrolet" },
                new Make { Id = 19, Name = "Chrysler" },
                new Make { Id = 20, Name = "Citroen" },
                new Make { Id = 21, Name = "Cupra" },
                new Make { Id = 22, Name = "Dacia" },
                new Make { Id = 23, Name = "Daewoo" },
                new Make { Id = 24, Name = "Daihatsu" },
                new Make { Id = 25, Name = "Dodge" },
                new Make { Id = 26, Name = "Ferrari" },
                new Make { Id = 27, Name = "Fiat" },
                new Make { Id = 28, Name = "Fisker" },
                new Make { Id = 29, Name = "Ford" },
                new Make { Id = 30, Name = "GMC" },
                new Make { Id = 31, Name = "Great Wall" },
                new Make { Id = 32, Name = "Honda" },
                new Make { Id = 33, Name = "Hummer" },
                new Make { Id = 34, Name = "Hyundai" },
                new Make { Id = 35, Name = "Infiniti" },
                new Make { Id = 36, Name = "Isuzu" },
                new Make { Id = 37, Name = "Iveco" },
                new Make { Id = 38, Name = "Jaguar" },
                new Make { Id = 39, Name = "Jeep" },
                new Make { Id = 40, Name = "Kia" },
                new Make { Id = 41, Name = "Lada" },
                new Make { Id = 42, Name = "Lamborghini" },
                new Make { Id = 43, Name = "Lancia" },
                new Make { Id = 44, Name = "Land Rover" },
                new Make { Id = 45, Name = "Lexus" },
                new Make { Id = 46, Name = "Lincoln" },
                new Make { Id = 47, Name = "Lotus" },
                new Make { Id = 48, Name = "Mahindra" },
                new Make { Id = 49, Name = "Maserati" },
                new Make { Id = 50, Name = "Maybach" },
                new Make { Id = 51, Name = "Mazda" },
                new Make { Id = 52, Name = "McLaren" },
                new Make { Id = 53, Name = "Mercedes-Benz" },
                new Make { Id = 54, Name = "MG" },
                new Make { Id = 55, Name = "Microcar" },
                new Make { Id = 56, Name = "Mini" },
                new Make { Id = 57, Name = "Mitsubishi" },
                new Make { Id = 58, Name = "Morgan" },
                new Make { Id = 59, Name = "Nissan" },
                new Make { Id = 60, Name = "Oldsmobile" },
                new Make { Id = 61, Name = "Opel" },
                new Make { Id = 62, Name = "Pagani" },
                new Make { Id = 63, Name = "Peugeot" },
                new Make { Id = 64, Name = "Plymouth" },
                new Make { Id = 65, Name = "Pontiac" },
                new Make { Id = 66, Name = "Porsche" },
                new Make { Id = 67, Name = "Renault" },
                new Make { Id = 68, Name = "Rolls-Royce" },
                new Make { Id = 69, Name = "Rover" },
                new Make { Id = 70, Name = "Saab" },
                new Make { Id = 71, Name = "Saturn" },
                new Make { Id = 72, Name = "Scion" },
                new Make { Id = 73, Name = "Seat" },
                new Make { Id = 74, Name = "Skoda" },
                new Make { Id = 75, Name = "Smart" },
                new Make { Id = 76, Name = "Spyker" },
                new Make { Id = 77, Name = "Ssangyong" },
                new Make { Id = 78, Name = "Subaru" },
                new Make { Id = 79, Name = "Suzuki" },
                new Make { Id = 80, Name = "Talbot" },
                new Make { Id = 81, Name = "Tata" },
                new Make { Id = 82, Name = "Tesla" },
                new Make { Id = 83, Name = "Toyota" },
                new Make { Id = 84, Name = "Trabant" },
                new Make { Id = 85, Name = "Triumph" },
                new Make { Id = 86, Name = "TVR" },
                new Make { Id = 87, Name = "Volkswagen" },
                new Make { Id = 88, Name = "Volga" },
                new Make { Id = 89, Name = "Volvo" },
                new Make { Id = 90, Name = "Warszawa" },
                new Make { Id = 91, Name = "Wartburg" },
                new Make { Id = 92, Name = "Wiesmann" },
            };

            await dbContext.Makes.AddRangeAsync(makes);
        }
    }
}
