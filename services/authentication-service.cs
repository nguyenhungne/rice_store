using rice_store.models;
using rice_store.repositories.interfaces;
using System.Diagnostics;

namespace rice_store.services
{
    public class AuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? Authenticate(string email, string password)
        {
            User? user = _userRepository.GetUserByEmail(email);

            if (user != null && HashingService.VerifyPassword(password, user.Password))
            {
                return user;
            }

            return null;
        }
    }
}
