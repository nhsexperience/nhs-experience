using Microsoft.Extensions.DependencyInjection;

namespace dhc;

public class HealthCheckProviderOptions
{
    public HealthCheckProviderOptions(IServiceCollection services)
    {
        Services = services;
        Filters = new HealthCheckProviderFilterOptions(services, this);
        GuidanceFilters = new HealthCheckProviderGuidanceFilterOptions(services, this);
        HealthCheckDataBuilders = new HealthCheckDataBuilderOptions(services, this);
    }

    public IServiceCollection Services {get; init;}
    public HealthCheckProviderFilterOptions Filters{get; init;}
    public HealthCheckProviderGuidanceFilterOptions GuidanceFilters{get; init;}

    public HealthCheckDataBuilderOptions HealthCheckDataBuilders{get;init;}
}