using MediatR;

namespace ECommerce.Application.Features.Auth.Commands.Register
{
    /// <summary>
    /// RegisterCommand
    /// </summary>
    /// <param name="Username"></param>
    /// <param name="Email"></param>
    /// <param name="Password"></param>
    public record RegisterCommand(string Username, string Email, string Password) : IRequest<int>;
}
