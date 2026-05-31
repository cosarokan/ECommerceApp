using Dapper;
using ECommerce.Application.Interfaces;
using MediatR;
using System.Data;

namespace ECommerce.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryHandler: IRequestHandler<GetAllBrandsQuery, List<BrandDto>>
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public GetAllBrandsQueryHandler(IDbConnectionFactory dbConnectionFactory)
        {
             _dbConnectionFactory = dbConnectionFactory;   
        }

        public async Task<List<BrandDto>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            var result = await connection.QueryAsync<BrandDto>("sp_GetAllBrands", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
