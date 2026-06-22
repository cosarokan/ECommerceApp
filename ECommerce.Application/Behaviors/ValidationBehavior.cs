using FluentValidation;
using MediatR;

namespace ECommerce.Application.Behaviors
{
    /// <summary>
    /// ValidationBehavior
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        /// <summary>
        /// ValidationBehavior
        /// </summary>
        /// <param name="validators"></param>
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request"></param>
        /// <param name="next"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException"></exception>
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_validators.Any())
            {
                return await next();
            }

            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(x =>x.ValidateAsync(context, cancellationToken)));

            var failures = validationResults
                .SelectMany(x => x.Errors)
                .Where(x => x is not null)
                .ToList();

            if (failures.Any())
            {
                throw new ValidationException(failures);
            }
                
            return await next();
        }
    }
}
