using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> GetAdmins();
        Task<Admin> GetAdminByID(Guid adminId);
        Task<Admin> InsertAdmin(Admin adminModel);
        Task<Admin> UpdateAdmin(Admin adminModel);
        Task<bool> DeleteAdmin(Guid id);
    }
}
