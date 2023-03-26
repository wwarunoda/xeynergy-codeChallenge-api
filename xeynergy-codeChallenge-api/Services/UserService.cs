using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Entities;
using xeynergy_codeChallenge_api.Models;
using xeynergy_codeChallenge_api.Repository;

namespace xeynergy_codeChallenge_api.Services
{
    public class UserService : IUserService
    {        
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository,IMapper mapper)
        {            
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<bool> DeleteUser(Guid id) => await _userRepository.DeleteUser(id);
        public async Task<UserDto> GetUserByID(Guid userId)
        {
            var user = await _userRepository.GetUserByID(userId);
            return _mapper.Map<UserDto>(user);
        }
        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }
        public async Task<UserDto> InsertUser(UserModel userModel) 
        {
            var user = _mapper.Map<User>(userModel);
            var insertedUser = await _userRepository.InsertUser(user);
            return _mapper.Map<UserDto>(insertedUser);
        }
        public async Task<UserDto> UpdateUser(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);
            var insertedUser = await _userRepository.UpdateUser(user);
            return _mapper.Map<UserDto>(insertedUser);
        }
    }
}
