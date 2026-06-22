using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Auth.Commands.Register
{
    /// <summary>
    /// RegisterCommandHandler
    /// </summary>
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, int>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;

        /// <summary>
        /// RegisterCommandHandler
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="passwordService"></param>
        public RegisterCommandHandler(IUserRepository userRepository, IPasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public async Task<int> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var exists = await _userRepository.ExistsByEmailAsync(request.Email);

            if (exists)
            {
                throw new Exception("Email already exists.");
            }
                
            var user = new User
            {
                Username = request.Username,
                Email = request.Email,
                PasswordHash = _passwordService.Hash(request.Password),
                IsActive = true,
                CreatedDate = DateTime.UtcNow
            };

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return user.Id;
        }
    }
}
