using ECommerce.Application.Features.Auth.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// AuthController
        /// </summary>
        /// <param name="mediator"></param>
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;              
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterCommand command)
        {
            var user = await _mediator.Send(command);

            return Ok(user);
        }
    }
}
