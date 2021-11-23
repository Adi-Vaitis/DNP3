using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP3.Models;
using DNP3.Persistence;
using DNP3.Repo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;

namespace DNP3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            SeedDatabase();
        }

        private static async Task SeedDatabase()
        {
            Repository repository = new Repository();
            
            List<Adult> adults = repository.GetAdultsAsync().GetAwaiter().GetResult().ToList();
            if (!adults.Any())
            {
                Console.WriteLine("No adults, seeding database from file");
                IList<Adult> seedAdults = GetAdultsFromFile();
                foreach (var adult in seedAdults)
                {
                    await repository.AddAdultAsync(adult);
                }
            }

            List<Family> families = repository.FetchFamiliesAsync().GetAwaiter().GetResult().ToList();
            if (!families.Any())
            {
                Console.WriteLine("No families, seeding database from file");
                IList<Family> seedFamilies = GetFamiliesFromFile();
                foreach (var family in seedFamilies)
                {
                    await repository.CreateFamily(family);
                }
            }
        }

        private static IList<Adult> GetAdultsFromFile()
        {
            Console.WriteLine("Getting adults from file");
            FileContext fileContext = new FileContext();
            IList<Adult> adults = fileContext.Adults;
            return adults;
        }
        
        private static IList<User> GetUsersFromFile()
        {
            Console.WriteLine("Getting users from file");
            FileContext fileContext = new FileContext();
            IList<User> users = fileContext.Users;
            return users;
        }

        private static IList<Family> GetFamiliesFromFile()
        {
            Console.WriteLine("Getting families from file");
            FileContext fileContext = new FileContext();
            IList<Family> families = fileContext.Families;
            return families;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}