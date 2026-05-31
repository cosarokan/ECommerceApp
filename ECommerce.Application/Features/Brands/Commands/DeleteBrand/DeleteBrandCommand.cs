using MediatR;

namespace ECommerce.Application.Features.Brands.Commands.DeleteBrand
{
    /// <summary>
    /// DeleteBrandCommand
    /// </summary>
    /// <param name="id"></param>
    public record DeleteBrandCommand(int id) : IRequest<bool>;
}
