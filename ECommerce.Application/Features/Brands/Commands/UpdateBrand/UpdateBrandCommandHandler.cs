using ECommerce.Application.Interfaces;
using MediatR;

namespace ECommerce.Application.Features.Brands.Commands.UpdateBrand
{
    /// <summary>
    /// UpdateBrandCommandHandler
    /// </summary>
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, bool>
    {
        private readonly IBrandRepository _brandRepository;

        /// <summary>
        /// UpdateBrandCommandHandler
        /// </summary>
        /// <param name="brandRepository"></param>
        public UpdateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;              
        }

        /// <summary>
        /// Updates the branch name.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetByIdAsync(request.Id);

            if (brand is null)
            {
                //logs
                return false;
            }

            brand.Name = request.Name;
            _brandRepository.Update(brand);
            await _brandRepository.SaveChangesAsync();

            return true;
        }
    }
}
