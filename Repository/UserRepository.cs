using DotLearn.Data;
using DotLearn.Interfaces;
using DotLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace DotLearn.Repository
{
    public class UserRepository : IUser
    {
        private AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == username.ToLower() && u.Password == password);

            if (user == null)  return null;

            return new User
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Email = user.Email,
                Role = user.Role
            };
        }
    }
}
