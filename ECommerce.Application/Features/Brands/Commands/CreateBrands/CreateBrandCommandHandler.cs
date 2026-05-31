using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Brands.Commands.CreateBrands
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, int>
    {
        private readonly IBrandRepository _brandRepository;

        /// <summary>
        /// CreateBrandCommandHandler
        /// </summary>
        /// <param name="brandRepository"></param>
        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;                
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<int> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Brand
            {
                Name = request.Name,
                CreatedDate = DateTime.Now,
                CreatedUser = "okan"
            };

            await _brandRepository.AddAsync(brand);


            return brand.Id;
        }
    }
}
