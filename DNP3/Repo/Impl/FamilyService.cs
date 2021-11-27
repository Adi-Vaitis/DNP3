using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP3.DataAccess;
using DNP3Client.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DNP3Client.Repo.Impl
{
    public class FamilyService : IFamilyService
    {
         private readonly DNPDbContext _databaseContext;

        public FamilyService()
        {
            _databaseContext = new DNPDbContext();
        }

        public async Task<IList<Family>> GetAllFamiliesAsync()
        {
            Console.WriteLine("Get families");
            return await _databaseContext.Families.
                Include(f => f.Adults).
                Include(f => f.Children)
                .ThenInclude(c => c.Interests).
                Include(f => f.Children).
                ThenInclude(c => c.Pets).Include(f => f.Pets)
                .ToListAsync();
        }

        public async Task<Family> GetFamilyAsync(int id)
        {
            Console.WriteLine("Get family");
            return _databaseContext.Families.Where(f => f.Id == id).Include(f => f.Adults).ThenInclude(a => a.JobTitle).First();
        }

        public async Task<Family> AddFamilyAsync(Family family)
        {
            await _databaseContext.Families.AddAsync(family);
            Console.WriteLine("From server: " + family.HouseNumber);
            await _databaseContext.SaveChangesAsync();
            Console.WriteLine("Add");
            return family;
        }

        public async Task<Family> RemoveFamilyAsync(int familyId)
        {
            Family toRemove = _databaseContext.Families.First(f => f.Id == familyId);
            _databaseContext.Families.Remove(toRemove);
            await _databaseContext.SaveChangesAsync();
            Console.WriteLine("Remove");
            return toRemove;
        }

        public async Task<Family> UpdateAsync(Family family)
        {
            List<Adult> adults = new List<Adult>();

            _databaseContext.Families.Update(family);
            await _databaseContext.SaveChangesAsync();
            Console.WriteLine("Update");
            return family;
        }
    }
}