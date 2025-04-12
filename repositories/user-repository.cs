using System.Diagnostics;
using System.Linq;
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
    }
}
