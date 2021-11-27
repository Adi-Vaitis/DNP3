using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Models;

namespace DNP3Client.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetAllFamiliesAsync();
        Task<Family> GetFamilyAsync(int id);

        Task<Family> AddFamilyAsync(Family family);

        Task<Family> RemoveFamilyAsync(int id);

        Task<Family> UpdateAsync(Family family);
    }
}