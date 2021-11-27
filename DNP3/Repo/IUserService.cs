using System.Threading.Tasks;
using Models;

namespace DNP3Client.Authentication
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(string username, string password);
    }
}