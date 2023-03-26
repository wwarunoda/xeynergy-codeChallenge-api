using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Models;
using xeynergy_codeChallenge_api.Services;

namespace xeynergy_codeChallenge_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<UserDto>> GetUsers()
        {
            var users = await _userService.GetUsers();
            if (users != null && users.Count() > 0)
                return Ok(users);
            else return NotFound(users);
        }
        [HttpGet("{userId:Guid}")]
        public async Task<ActionResult<UserDto>> GetUserByID(Guid userId)
        {
            var users = await _userService.GetUserByID(userId);
            if(users != null)
                return Ok(users);
            else return NotFound(users);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid userId)
        {
            var isDeleted = await _userService.DeleteUser(userId);
            if (isDeleted)
                return Ok();
            else return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>> InsertUser(UserModel userModel)
        {
            var user = await _userService.InsertUser(userModel);
            if (user != null)
                return Ok(user);
            else return NotFound(user);
        }
        [HttpPut]
        public async Task<ActionResult<UserDto>> UpdateUser(UserModel userModel)
        {
            var user = await _userService.UpdateUser(userModel);
            if (user != null)
                return Ok(user);
            else return NotFound(user);
        }

    }
}
