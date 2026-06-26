using BlazorTraining.Data.Context;
using BlazorTraining.Domain.Models;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace BlazorTraining.Data.DataSeeder
{
    public static class DatabaseSeeder
    {
        public static void SeedServers(ApplicationDbContext context)
        {
            if (!context.Server.Any())
            {
                var names = new[]
{
    "Windows", "Linux", "macOS", "Ubuntu", "Debian", "Fedora",
    "CentOS", "RedHat", "Android", "iOS",
    "ChromeOS", "FreeBSD", "OpenBSD", "Solaris", "Mint",
    "Kali", "Arch", "Manjaro", "Elementary", "Zorin"
};

                var regions = new[]
                {
    "USA", "Germany", "Canada", "France", "Italy",
    "Japan", "China", "Iran", "Brazil", "India",
    "Australia", "Turkey", "Spain", "Mexico", "Sweden"
};

                var rnd = new Random();

                var data = Enumerable.Range(1, 100)
                    .Select(i => new Server
                    {
                        Name = $"{names[rnd.Next(names.Length)]} {i}",
                        Region = regions[rnd.Next(regions.Length)],
                        ActiveStatus = rnd.Next(2) == 1,
                        RowId = Guid.NewGuid().ToString()
                    })
                    .ToList();

                //var faker = new Faker<Server>()
                //    //.RuleFor(x => x.Id, f => f.IndexFaker + 1)
                //    .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                //    .RuleFor(x => x.Region, f => f.Address.Country())
                //    .RuleFor(x => x.ActiveStatus, f => f.Random.Bool())
                //    .RuleFor(x => x.RowId, _ => Guid.NewGuid().ToString());

                //var data = faker.Generate(100);

                context.AddRange(data);
                context.SaveChanges();
            }
        }
    }
}
