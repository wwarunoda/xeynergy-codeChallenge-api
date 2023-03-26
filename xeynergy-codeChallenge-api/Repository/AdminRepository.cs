using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Contexts;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly IdentityDbContext _identityDbContext;        
        public AdminRepository(IdentityDbContext context)
        {
            _identityDbContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Admin>> GetAdmins()
        {
            return _identityDbContext.Admins.ToList();                    
        }

        public async Task<Admin> GetAdminByID(Guid adminId)
        {
            return await _identityDbContext.Admins.FindAsync(adminId);
        }

        public async Task<Admin> InsertAdmin(Admin admin)
        {
            _identityDbContext.Admins.Add(admin);
            await _identityDbContext.SaveChangesAsync();
            return admin;
        }

        public async Task<Admin> UpdateAdmin(Admin admin)
        {
            _identityDbContext.Admins.Update(admin);
            await _identityDbContext.SaveChangesAsync();
            return admin;
        }
        public async Task<bool> DeleteAdmin(Guid id)
        {
            var admin = _identityDbContext.Admins.Find(id);
            if (admin != null)
            {
                _identityDbContext.Admins.Remove(admin);
                await _identityDbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
