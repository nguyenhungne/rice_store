using rice_store.models;

namespace rice_store.repositories.interfaces
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);
        void AddUser(User user);
        Task<IEnumerable<User>> GetAllUsersAsync(string nameFilter = null, string emailFilter = null);
        Task SortDeleteUserAsync(int id);
        Task<User> GetUserByIdAsync(int id);
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
    }
}
