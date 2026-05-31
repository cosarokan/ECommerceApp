using Dapper;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using MediatR;
using System.Data;

namespace ECommerce.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryHandler: IRequestHandler<GetAllBrandsQuery, List<BrandDto>>
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        private readonly ICacheService _cacheService;

        public GetAllBrandsQueryHandler(IDbConnectionFactory dbConnectionFactory, ICacheService cacheService)
        {
            _dbConnectionFactory = dbConnectionFactory;   
            _cacheService = cacheService;
        }

        public async Task<List<BrandDto>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            const string cacheKey = "brands";
            var cached = await _cacheService.GetAsync<List<BrandDto>>(cacheKey);

            if (cached is not null)
            {
                return cached;
            }

            using var connection = _dbConnectionFactory.CreateConnection();
            var brands = (await connection.QueryAsync<BrandDto>("sp_GetAllBrands", commandType: CommandType.StoredProcedure)).ToList();

            await _cacheService.SetAsync(cacheKey, brands, TimeSpan.FromSeconds(30));


            return brands;
        }
    }
}
