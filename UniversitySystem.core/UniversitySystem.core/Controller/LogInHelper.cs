using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.core.Model;

namespace UniversitySystem.core.Services
{
    internal class LogInHelper
    {
        private string username = "user";
        private string hashedpw = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4"; //1234

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public bool Authenticate(User user)
        {
            if (!string.Equals(username, user.UserName, StringComparison.OrdinalIgnoreCase)) { return false; }

            string hashedInput = HashPassword(user.Password);
            return string.Equals(hashedInput, hashedpw, StringComparison.OrdinalIgnoreCase);
        }

    }
}
