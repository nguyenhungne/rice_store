using rice_store.models;

namespace rice_store.repositories.interfaces
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);
        void AddUser(User user);
    }
}
