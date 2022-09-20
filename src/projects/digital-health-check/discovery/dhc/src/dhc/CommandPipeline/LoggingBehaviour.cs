namespace dhc;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System.Reflection;

public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private static readonly Counter _c_commandhandler_handling =
        Metrics.CreateCounter("commandhandler_handling_counter", "Health Check Command Handling",     
            new CounterConfiguration
            { 
             LabelNames = new[] { "commandName" }
            }
        );

    private static readonly Counter _c_commandhandler_handled =
        Metrics.CreateCounter("commandhandler_handled_counter", "Health Check Command Handled",     
            new CounterConfiguration
            { 
             LabelNames = new[] { "commandName" }
            }
        );        

    private readonly ILogger<LoggingBehaviour<TRequest, TResponse>> _logger;
    public LoggingBehaviour(ILogger<LoggingBehaviour<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }
    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        //Request
        _c_commandhandler_handling.WithLabels(typeof(TRequest).Name).Inc();
        _logger.LogInformation($"Handling {typeof(TRequest).Name}");
        Type myType = request.GetType();
        IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
        foreach (PropertyInfo prop in props)
        {
            object propValue = prop.GetValue(request, null);
            _logger.LogInformation("{Property} : {@Value}", prop.Name, propValue);
        }
        var response = await next();
        //Response
        _c_commandhandler_handled.WithLabels(typeof(TRequest).Name).Inc();
        _logger.LogInformation($"Handled {typeof(TResponse).Name}");
        return response;
    }
}