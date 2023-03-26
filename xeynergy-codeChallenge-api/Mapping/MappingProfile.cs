using AutoMapper;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Entities;
using xeynergy_codeChallenge_api.Models;

namespace xeynergy_codeChallenge_api.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Person, PersonDto>();
            CreateMap<PersonModel, Person>();
            CreateMap<User, UserDto>();
            CreateMap<UserModel, User>();
            CreateMap<Admin, AdminDto>();
            CreateMap<AdminModel, Admin>();
            CreateMap<UserGroup, UserGroupDto>();
            CreateMap<AccessRule, AccessRuleDto>();
        }
    }
}
