using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Contexts;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public class UserGroupRepository : IUserGroupRepository
    {
        private readonly IdentityDbContext _identityDbContext;        
        public UserGroupRepository(IdentityDbContext context)
        {
            _identityDbContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<UserGroup>> GetUserGroups()
        {
            return _identityDbContext.UserGroups.ToList();            
        }        
    }
}
