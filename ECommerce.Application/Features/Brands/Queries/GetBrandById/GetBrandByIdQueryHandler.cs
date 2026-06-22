using Dapper;
using ECommerce.Application.Interfaces;
using MediatR;

namespace ECommerce.Application.Features.Brands.Queries.GetBrandById
{
    /// <summary>
    /// GetBrandByIdQueryHandler
    /// </summary>
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, BrandDetailDto?>
    {
        private readonly IDbConnectionFactory _connectionFactory;

        /// <summary>
        /// GetBrandByIdQueryHandler
        /// </summary>
        /// <param name="connectionFactory"></param>
        public GetBrandByIdQueryHandler(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<BrandDetailDto?> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            using var connection = _connectionFactory.CreateConnection();
            var parameters = new DynamicParameters();
            parameters.Add("@id", request.Id);

            var result = await connection.QueryFirstOrDefaultAsync<BrandDetailDto>("sp_GetBrandById", parameters, commandType: System.Data.CommandType.StoredProcedure);

            return result;
        }
    }
}
