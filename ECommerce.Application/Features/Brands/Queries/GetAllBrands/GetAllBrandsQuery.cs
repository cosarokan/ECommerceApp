using MediatR;

namespace ECommerce.Application.Features.Brands.Queries.GetAllBrands
{
    /// <summary>
    /// GetAllBrandsQuery
    /// </summary>
    public record GetAllBrandsQuery : IRequest<List<BrandDto>>;
}
