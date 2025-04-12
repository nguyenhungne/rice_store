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

        public bool Authenticate(string email, string password)
        {
            User? user = _userRepository.GetUserByEmail(email);
            return HashingService.VerifyPassword(password, user?.Password);
        }
    }
}
