namespace dhc;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using FluentValidation;

public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private static readonly Counter _c_commandhandler_validation =
        Metrics.CreateCounter("commandhandler_validation_counter", "Health Check Command Validated",     
            new CounterConfiguration
            { 
             LabelNames = new[] { "commandName", "validationStatus", "property", "error" }
            }
        ); 

    private readonly IEnumerable<IValidator<TRequest>> _validators;
    public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
            foreach(var result in validationResults)
            {
                if(result.Errors.Count>=0)
                {
                    foreach(var error in result.Errors)
                    {
                         _c_commandhandler_validation.WithLabels(typeof(TRequest).Name, "Failed", error.PropertyName, error.ErrorMessage).Inc();
                    }
                }
            }
            var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
            if (failures.Count != 0)
            {
                
                throw new FluentValidation.ValidationException(failures);
            }
            else
            {
                 _c_commandhandler_validation.WithLabels(typeof(TRequest).Name, "Success", string.Empty, string.Empty).Inc();
            }

            
        }
        return await next();
    }
}
