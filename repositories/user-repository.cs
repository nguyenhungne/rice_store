using System.Diagnostics;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using rice_store.data;
using rice_store.models;
using rice_store.repositories.interfaces;

namespace rice_store.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User? GetUserByEmail(string email)
        {
            User? user = _context.User.FirstOrDefault(user => user.Email == email);
            return user;
        }

        public void AddUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(string nameFilter = null, string emailFilter = null)
        {
            var query = _context.User.AsQueryable();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                query = query.Where(u => u.Name.ToLower().Contains(nameFilter.ToLower()));
            }

            if (!string.IsNullOrEmpty(emailFilter))
            {
                query = query.Where(u => u.Email.ToLower().Contains(emailFilter.ToLower()));
            }

            return await query.ToListAsync();
        }

        public async Task SortDeleteUserAsync(int id)
        {
            var user = await _context.User.FindAsync(id) ?? throw new InvalidOperationException($"User with ID {id} not found.");
            user.IsDeleted = true;
            _context.User.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.User.FirstOrDefaultAsync(u => u.Id == id)
                   ?? throw new InvalidOperationException($"User with ID {id} not found.");
        }

        public async Task<User> AddUserAsync(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var existingUser = await _context.User.FindAsync(user.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException($"User with ID {user.Id} not found.");
            }

            existingUser.Username = user.Username;
            existingUser.Password = user.Password != null ? user.Password : existingUser.Password;
            existingUser.Username = user.Username;
            existingUser.Role = user.Role;
            existingUser.Name = user.Name;
            existingUser.Phone = user.Phone;
            existingUser.Email = user.Email;
            existingUser.Salary = user.Salary;

            await _context.SaveChangesAsync();
            return existingUser;
        }
    }
}
