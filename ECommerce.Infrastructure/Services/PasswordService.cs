using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Services
{
    /// <summary>
    /// PasswordService
    /// </summary>
    public class PasswordService : IPasswordService
    {
        private readonly PasswordHasher<string> _hasher = new();

        /// <summary>
        /// Hash
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Hash(string password)
        {
            return _hasher.HashPassword(string.Empty, password);
        }

        /// <summary>
        /// Verify
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Verify(string password, string passwordHash)
        {
            var result = _hasher.VerifyHashedPassword(string.Empty, passwordHash, password);

            return result != PasswordVerificationResult.Failed;
        }
    }
}
