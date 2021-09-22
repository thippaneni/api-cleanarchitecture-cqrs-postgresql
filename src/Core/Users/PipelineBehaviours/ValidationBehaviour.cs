using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;

namespace Rusv.UserManagement.Core.Users.PipelineBehaviours
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var context = new ValidationContext<TRequest>(request);
            var validationErrors = _validators
                .Select(validationResult => validationResult.Validate(context))
                .SelectMany(validationResult => validationResult.Errors)
                .Where(validationResult => validationResult != null)
                .ToList();

            if (validationErrors.Any())
            {
                throw new ValidationException(validationErrors);
            }
            return next();
        }
    }
}
