using System.Threading.Tasks;
using DNP3Client.Models;

namespace DNP3Client.Data
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);

    }
}