using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Repository;

namespace xeynergy_codeChallenge_api.Services
{
    public class UserGroupService : IUserGroupService
    {        
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        private readonly IUserGroupRepository _userGroupRepository;
        public UserGroupService(IUserGroupRepository userGroupRepository,IMapper mapper)
        {            
            _mapper = mapper;
            _userGroupRepository = userGroupRepository;
        }        
        public async Task<IEnumerable<UserGroupDto>> GetUserGroups()
        {
            var userGroups = await _userGroupRepository.GetUserGroups();
            return _mapper.Map<IEnumerable<UserGroupDto>>(userGroups);
        }
    }
}
