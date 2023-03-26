using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Models;

namespace xeynergy_codeChallenge_api.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsers();
        Task<UserDto> GetUserByID(Guid userId);
        Task<UserDto> InsertUser(UserModel userModel);
        Task<UserDto> UpdateUser(UserModel userModel);
        Task<bool> DeleteUser(Guid Id);
    }
}
