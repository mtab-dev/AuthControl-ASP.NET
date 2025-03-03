using AuthControl.API.DTO;
using System.Security.Cryptography;
using System.Text;

namespace AuthControl.API.Utils
{
    public class PasswordService
    {
      public static PasswordServiceDTO CreateHash(string password)
        {
            using var hmac = new HMACSHA256();

            return new PasswordServiceDTO
            {
                Salt = Convert.ToBase64String(hmac.Key),
                Hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)))
            };
        }

        public static bool VerifyPassword(string password, PasswordServiceDTO dto)
        {
            using var hmac = new HMACSHA256(Convert.FromBase64String(dto.Salt));

            var computedHas = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
            
            return computedHas == dto.Hash;
        }
    }
}
