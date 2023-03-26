using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Contexts;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IdentityDbContext _identityDbContext;        
        public UserRepository(IdentityDbContext context)
        {
            _identityDbContext = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return _identityDbContext.Users.ToList();            
        }

        public async Task<User> GetUserByID(Guid userId)
        {
            return await _identityDbContext.Users.FindAsync(userId);
        }

        public async Task<User> InsertUser(User user)
        {
            _identityDbContext.Users.Add(user);
            await _identityDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            _identityDbContext.Users.Update(user);
            await _identityDbContext.SaveChangesAsync();
            return user;
        }
        public async Task<bool> DeleteUser(Guid id)
        {
            var User = _identityDbContext.Users.Find(id);
            if (User != null)
            {
                _identityDbContext.Users.Remove(User);
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
