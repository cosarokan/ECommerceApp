using FluentValidation;

namespace ECommerce.Application.Features.Brands.Commands.CreateBrands
{
    /// <summary>
    /// CreateBrandCommandValidator
    /// </summary>
    public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
    {
        /// <summary>
        /// CreateBrandCommandValidator
        /// </summary>
        public CreateBrandCommandValidator()
        {
            RuleFor(x => x.Name)
                    .Must(x => !string.IsNullOrWhiteSpace(x))
                    .WithMessage("Brand name is required!")
                    .MaximumLength(50)
                    .WithMessage("Brand name must be exceed 50 characters!");
        }
    }
}
