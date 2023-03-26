using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public interface IAccessRuleRepository
    {
        Task<IEnumerable<AccessRule>> GetAccessRules();
    }
}
