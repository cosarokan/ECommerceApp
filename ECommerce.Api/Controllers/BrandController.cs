using ECommerce.Application.Features.Brands.Commands.CreateBrands;
using ECommerce.Application.Features.Brands.Commands.DeleteBrand;
using ECommerce.Application.Features.Brands.Commands.UpdateBrand;
using ECommerce.Application.Features.Brands.Queries.GetAllBrands;
using ECommerce.Application.Features.Brands.Queries.GetBrandById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    /// <summary>
    /// BrandController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// BrandController
        /// </summary>
        /// <param name="mediator"></param>
        public BrandController(IMediator mediator)
        {
            _mediator = mediator;            
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post(CreateBrandCommand createBrandCommand)
        {
            var result = await _mediator.Send(createBrandCommand);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteBrandCommand(id));

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, UpdateBrandCommand updateBrandCommand)
        {
            var result = await _mediator.Send(updateBrandCommand);

            if (!result)
            {
                return NotFound();
            }
            
            return NoContent();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetBrandByIdQuery(id));

            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
