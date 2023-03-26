using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Models;

namespace xeynergy_codeChallenge_api.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<AdminDto>> GetAdmins();
        Task<AdminDto> GetAdminByID(Guid adminId);
        Task<AdminDto> InsertAdmin(AdminModel adminModel);
        Task<AdminDto> UpdateAdmin(AdminModel adminModel);
        Task<bool> DeleteAdmin(Guid Id);
    }
}
