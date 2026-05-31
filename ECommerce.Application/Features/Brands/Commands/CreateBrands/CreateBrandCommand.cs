using MediatR;

namespace ECommerce.Application.Features.Brands.Commands.CreateBrands
{
    //Return int value.
    public record CreateBrandCommand(string Name) : IRequest<int>;
}
