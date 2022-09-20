using Microsoft.Extensions.DependencyInjection;

namespace dhc;

public class HealthCheckProviderGuidanceFilterOptions: HealthCheckProviderTypeOptions<IHealthCheckGuidanceFilter>
{
    
    public HealthCheckProviderGuidanceFilterOptions(
        IServiceCollection services,
        HealthCheckProviderOptions baseOptions):base(services, baseOptions)
        {

        }
}
