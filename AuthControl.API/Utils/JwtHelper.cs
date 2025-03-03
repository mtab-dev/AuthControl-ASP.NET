using AuthControl.API.Abstractions;
using AuthControl.API.Entitites;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthControl.API.Utils
{
    public class JwtHelper : IJwtHelper
    {
        private readonly SigningCredentials _signCreds;
        private readonly IConfigurationSection _jwt;

        public JwtHelper(IConfiguration configuration)
        {
            var jwtSection = configuration.GetSection("Jwt");
            _jwt = jwtSection;
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection["SecretKey"])); 
            _signCreds = new(secretKey, SecurityAlgorithms.HmacSha256);
        }

        public string GenerateToken(UserEntity user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _jwt["Issuer"],
                audience: _jwt["Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: _signCreds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
