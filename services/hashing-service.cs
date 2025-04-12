using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace rice_store.services
{
    public static class HashingService
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public static bool VerifyPassword(string inputPassword, string? storedHash)
        {
            return HashPassword(inputPassword) == storedHash;
        }
    }
}
