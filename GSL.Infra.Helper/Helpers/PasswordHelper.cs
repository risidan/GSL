using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;

namespace GSL.Infra.Helper.Helpers
{
    public static class PasswordHelper
    {
        private const string _salt = "CGYzqeN5clZekNC88Ujj1Q==";
        public static string HashPassword(this string password)
        {

              string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
              password: password,
              salt: Encoding.ASCII.GetBytes(_salt),
              prf: KeyDerivationPrf.HMACSHA256,
              iterationCount: 100000,
              numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
