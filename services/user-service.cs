using rice_store.models;
using rice_store.repositories.interfaces;
using rice_store.services;

using System.Collections.Generic;
using System.Threading.Tasks;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllUsersAsync(string nameFilter = null, string emailFilter = null);
    Task SortDeleteUserAsync(int id);
    Task<User> GetUserByIdAsync(int id);
    Task<User> AddUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
}

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync(string nameFilter = null, string emailFilter = null)
    {
        return await _userRepository.GetAllUsersAsync(nameFilter, emailFilter);
    }

    public async Task SortDeleteUserAsync(int id)
    {
        await _userRepository.SortDeleteUserAsync(id);
    }

    public async Task<User> AddUserAsync(User user)
    {
        User userWithHashedPassword = new User
        {
            Username = user.Username,
            Password = HashingService.HashPassword(user.Password),
            Name = user.Name,
            Role = user.Role,
            Phone = user.Phone,
            Email = user.Email,
            Salary = user.Salary
        };
        return await _userRepository.AddUserAsync(userWithHashedPassword);
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        User userWithHashedPassword = new User
        {
            Id = user.Id,
            Username = user.Username,
            Password = !string.IsNullOrEmpty(user.Password) ? HashingService.HashPassword(user.Password) : null,
            Name = user.Name,
            Role = user.Role,
            Phone = user.Phone,
            Email = user.Email,
            Salary = user.Salary
        };
        return await _userRepository.UpdateUserAsync(userWithHashedPassword);
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _userRepository.GetUserByIdAsync(id);
    }

}
