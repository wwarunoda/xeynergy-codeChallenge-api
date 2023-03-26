using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;

namespace xeynergy_codeChallenge_api.Services
{
    public interface IAccessRuleService
    {
        Task<IEnumerable<AccessRuleDto>> GetAccessRules();
    }
}
