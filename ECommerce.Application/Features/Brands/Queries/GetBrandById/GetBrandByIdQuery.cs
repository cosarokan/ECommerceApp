using MediatR;

namespace ECommerce.Application.Features.Brands.Queries.GetBrandById
{
    /// <summary>
    /// GetBrandByIdQuery
    /// </summary>
    /// <param name="Id"></param>
    public record GetBrandByIdQuery(int Id) : IRequest<BrandDetailDto?>;
}
