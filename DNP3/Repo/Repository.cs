using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP3.DataAccess;
using DNP3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;

namespace DNP3.Repo
{
    public class Repository
    {
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            await using DNPDbContext dbContext = new DNPDbContext();
            return dbContext.Adults.Include(adult => adult.JobTitle).ToList();
        }

        public async Task<Adult> GetFilteredAdultsAsync(int id)
        {
            IList<Adult> adults = await GetAdultsAsync();
            Adult adultToSend = null;
            foreach (Adult adult in adults)
            {
                if (id == adult.Id)
                {
                    adultToSend = adult;
                }
            }

            if (adultToSend != null)
            {
                return adultToSend;
            }
            else
            {
                throw new Exception("adult not found on API");
            }
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            await using DNPDbContext dbContext = new DNPDbContext();
            EntityEntry<Adult> newlyAdded = await dbContext.Adults.AddAsync(adult);
            await dbContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            await using DNPDbContext dbContext = new DNPDbContext();
            Adult adultToDelete = await dbContext.Adults.FirstOrDefaultAsync(adult => adult.Id == adultId);
            if (adultToDelete != null)
            {
                dbContext.Adults.Remove(adultToDelete);
                await dbContext.SaveChangesAsync();
            }
        }
        
         public async Task<User> ValidateUser(string username, string password)
        {
            await using DNPDbContext dbContext = new DNPDbContext();
            User user = dbContext.Users.FirstOrDefaultAsync(user1 => user1.UserName.Equals(username)).GetAwaiter()
                .GetResult();
            Console.WriteLine(user.ToString());
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!user.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return user;
        }

         public async Task<Family> CreateFamily(Family family)
         {
             await using DNPDbContext dbContext = new DNPDbContext();
             EntityEntry<Family> newlyAdded = await dbContext.Families.AddAsync(family);
             await dbContext.SaveChangesAsync();
             return newlyAdded.Entity;
         }

         public async Task DeleteFamily(int id)
         {
             await using DNPDbContext dbContext = new DNPDbContext();
             Family familyToDelete = await dbContext.Families.FirstOrDefaultAsync(family => family.Id == id);
             if (familyToDelete != null)
             {
                 dbContext.Families.Remove(familyToDelete);
                 await dbContext.SaveChangesAsync();
             }
         }

         public async Task<IList<Family>> FetchFamiliesAsync()
         {
             await using DNPDbContext dbContext = new DNPDbContext();
             return dbContext.Families.ToList();
         }
    }
}