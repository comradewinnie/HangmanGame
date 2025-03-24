using System;
using System.Security.Cryptography;
using System.Text;

namespace HangmanGame
{
    internal class Hashing
    {
        public static string GeneratePasswordHash(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha1.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        public static bool CheckPasswordHash(string password, string hash)
        {
            return GeneratePasswordHash(password) == hash;
        }
    }
}
