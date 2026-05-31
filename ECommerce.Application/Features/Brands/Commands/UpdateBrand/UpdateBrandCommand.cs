using MediatR;

namespace ECommerce.Application.Features.Brands.Commands.UpdateBrand
{
    public record UpdateBrandCommand(int Id, string Name) : IRequest<bool>;     
}
