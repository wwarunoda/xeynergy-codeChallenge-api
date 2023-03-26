using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Services;

namespace xeynergy_codeChallenge_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccessRuleController : ControllerBase
    {
        private readonly IAccessRuleService _accessRuleService;

        public AccessRuleController(IAccessRuleService accessRuleService)
        {
            _accessRuleService = accessRuleService;
        }

        [HttpGet]
        public async Task<ActionResult<AccessRuleDto>> GetAccessRules()
        {
            var accessRules = await _accessRuleService.GetAccessRules();
            if (accessRules != null && accessRules.Count() > 0)
                return Ok(accessRules);
            else return NotFound(accessRules);
        }
    }
}
