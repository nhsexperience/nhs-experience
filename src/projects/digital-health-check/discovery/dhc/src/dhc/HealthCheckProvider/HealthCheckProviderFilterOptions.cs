using Microsoft.Extensions.DependencyInjection;
using MediatR;
namespace dhc;

public class HealthCheckProviderFilterOptions: HealthCheckProviderTypeOptions<IHealthCheckFilter>
{
    public HealthCheckProviderFilterOptions(
        IServiceCollection serviceProvider,
        HealthCheckProviderOptions baseOptions):base(serviceProvider, baseOptions)
        {
            
        }
}

public class HealthCheckCommandHandlerOptions: HealthCheckProviderTypeOptions<object>
{
    public HealthCheckCommandHandlerOptions(
        IServiceCollection serviceProvider,
        HealthCheckProviderOptions baseOptions):base(serviceProvider, baseOptions)
        {
            
        }
}

