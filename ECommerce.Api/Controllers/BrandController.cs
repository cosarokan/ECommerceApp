using ECommerce.Application.Features.Brands.Commands.CreateBrands;
using ECommerce.Application.Features.Brands.Commands.DeleteBrand;
using ECommerce.Application.Features.Brands.Commands.UpdateBrand;
using ECommerce.Application.Features.Brands.Queries.GetAllBrands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;            
        }

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
    }
}
