using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace WekaWeka.Utils
{
    public static class PasswordHelper
    {
        public static string Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Password cannot be empty");

            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        public static bool Verify(string input, string storedHash)
        {
            var hashedInput = Hash(input);
            return hashedInput == storedHash;
        }
    }
}
