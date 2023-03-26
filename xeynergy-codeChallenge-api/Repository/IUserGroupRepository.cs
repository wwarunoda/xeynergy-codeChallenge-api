using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public interface IUserGroupRepository
    {
        Task<IEnumerable<UserGroup>> GetUserGroups();
    }
}
