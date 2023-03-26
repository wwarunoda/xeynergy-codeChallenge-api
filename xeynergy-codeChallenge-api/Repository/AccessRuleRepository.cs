using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Contexts;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public class AccessRuleRepository : IAccessRuleRepository
    {
        private readonly IdentityDbContext _identityDbContext;        
        public AccessRuleRepository(IdentityDbContext context)
        {
            _identityDbContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<AccessRule>> GetAccessRules()
        {
            return _identityDbContext.AccessRules.ToList();
        }        
    }
}
