using System.Collections.Generic;
using System.Threading.Tasks;
using DNP3Client.Models;

namespace DNP3Client.Data
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetAllFamiliesAsync();
        Task<Family> GetFamilyAsync(int id);

        Task AddFamilyAsync(Family family);

        Task<Family> RemoveFamilyAsync(int id);

        Task UpdateAsync(Family family);
    }
}