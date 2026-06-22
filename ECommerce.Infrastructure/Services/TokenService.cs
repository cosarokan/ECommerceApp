using ECommerce.Application.Common;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECommerce.Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtOption _jwtOption;

        /// <summary>
        /// TokenService
        /// </summary>
        /// <param name="jwtOption"></param>
        public TokenService(IOptions<JwtOption> jwtOption)
        {
            _jwtOption = jwtOption.Value;
        }

        /// <summary>
        /// CreateToken
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.SecretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddMinutes(_jwtOption.Expiration);
            var token = new JwtSecurityToken(issuer: _jwtOption.Issuer, audience: _jwtOption.Audience, claims: claims, expires: expires, signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
