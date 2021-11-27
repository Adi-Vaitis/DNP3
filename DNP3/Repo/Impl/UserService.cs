using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using DNP3.DataAccess;
using DNP3Client.Authentication;
using Models;

namespace DNP3Client.Data.Impl
{
    public class UserService : IUserService
    {
        private readonly DNPDbContext _databaseContext;

        public UserService(DNPDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User first = _databaseContext.Users.FirstOrDefault(user => user.Username.Equals(username));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}