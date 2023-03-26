using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Repository;

namespace xeynergy_codeChallenge_api.Services
{
    public class AccessRuleService : IAccessRuleService
    {        
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        private readonly IAccessRuleRepository _accessRuleRepository;
        public AccessRuleService(IAccessRuleRepository accessRuleRepository,IMapper mapper)
        {            
            _mapper = mapper;
            _accessRuleRepository = accessRuleRepository;
        }        
        public async Task<IEnumerable<AccessRuleDto>> GetAccessRules()
        {
            var accessRules = await _accessRuleRepository.GetAccessRules();
            return _mapper.Map<IEnumerable<AccessRuleDto>>(accessRules);
        }
    }
}
