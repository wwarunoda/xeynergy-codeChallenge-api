using Microsoft.AspNetCore.Mvc;
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
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<ActionResult<AdminDto>> GetAdmins()
        {
            var admins = await _adminService.GetAdmins();
            if (admins != null && admins.Count() > 0)
                return Ok(admins);
            else return NotFound(admins);
        }
        [HttpGet("{AdminId:Guid}")]
        public async Task<ActionResult<AdminDto>> GetAdminByID(Guid adminId)
        {
            var admins = await _adminService.GetAdminByID(adminId);
            if(admins != null)
                return Ok(admins);
            else return NotFound(admins);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAdmin(Guid adminId)
        {
            var isDeleted = await _adminService.DeleteAdmin(adminId);
            if (isDeleted)
                return Ok();
            else return NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<AdminDto>> InsertAdmin(AdminModel adminModel)
        {
            var admin = await _adminService.InsertAdmin(adminModel);
            if (admin != null)
                return Ok(admin);
            else return NotFound(admin);
        }
        [HttpPut]
        public async Task<ActionResult<AdminDto>> UpdateAdmin(AdminModel adminModel)
        {
            var admin = await _adminService.UpdateAdmin(adminModel);
            if (admin != null)
                return Ok(admin);
            else return NotFound(admin);
        }

    }
}
