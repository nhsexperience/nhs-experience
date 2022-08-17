using Microsoft.Extensions.DependencyInjection;

namespace dhc;

public class HealthCheckProviderFilterOptions: HealthCheckProviderTypeOptions<IHealthCheckFilter>
{
    public HealthCheckProviderFilterOptions(
        IServiceCollection serviceProvider,
        HealthCheckProviderOptions baseOptions):base(serviceProvider, baseOptions)
        {
            
        }
}
