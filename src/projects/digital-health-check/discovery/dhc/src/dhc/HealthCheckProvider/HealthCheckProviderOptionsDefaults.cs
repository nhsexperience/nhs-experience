using Microsoft.Extensions.DependencyInjection;

namespace dhc;

public static class HealthCheckProviderOptionsDefaults
{
    public static HealthCheckProviderOptions Defaults(IServiceCollection services)
    {
        var options = new HealthCheckProviderOptions(services);
        options.Filters.Add<HealthCheckFilterBp>();
        options.Filters.Add<HealthCheckFilterBmi>();
        options.GuidanceFilters.Add<HealthCheckGuidanceFilterBp>();
        options.GuidanceFilters.Add<HealthCheckGuidanceFilterWeight>();
        options.HealthCheckDataBuilders.Add<HealthCheckDataBuilderBuildFilterBasicObs>();
        options.HealthCheckDataBuilders.Add<HealthCheckDataBuilderBuildFilterDemographics>();
        options.HealthCheckDataBuilders.Add<HealthCheckDataBuilderBuildFilterBloodPressure>();
        return options;
    }
}
