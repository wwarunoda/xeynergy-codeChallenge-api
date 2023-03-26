using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserByID(Guid userId);
        Task<User> InsertUser(User userModel);
        Task<User> UpdateUser(User userModel);
        Task<bool> DeleteUser(Guid id);
    }
}
