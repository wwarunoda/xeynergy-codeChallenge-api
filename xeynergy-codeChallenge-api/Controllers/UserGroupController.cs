using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Services;

namespace xeynergy_codeChallenge_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserGroupController : ControllerBase
    {
        private readonly IUserGroupService _userGroupService;

        public UserGroupController(IUserGroupService userGroupService)
        {
            _userGroupService = userGroupService;
        }

        [HttpGet]
        public async Task<ActionResult<UserGroupDto>> GetUserGroups()
        {
            var userGroups = await _userGroupService.GetUserGroups();
            if (userGroups != null && userGroups.Count() > 0)
                return Ok(userGroups);
            else return NotFound(userGroups);
        }        
    }
}
