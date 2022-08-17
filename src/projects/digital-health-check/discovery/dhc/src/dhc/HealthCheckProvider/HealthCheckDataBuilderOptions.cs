using Microsoft.Extensions.DependencyInjection;

namespace dhc;

public class HealthCheckDataBuilderOptions: HealthCheckProviderTypeOptions<IHealthCheckDataBuilderBuildFilter>
{
    public HealthCheckDataBuilderOptions(
        IServiceCollection serviceProvider,
        HealthCheckProviderOptions baseOptions):base(serviceProvider, baseOptions)
        {
            
        }
}
