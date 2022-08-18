using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace dhc;


public static class HealthCheckProviderExtensionMethods
{
    public static IServiceCollection AddHealthCheckProvider(this IServiceCollection services)
    {
        return AddHealthCheckProvider(services, (o)=>{});
    }

    public static IServiceCollection AddHealthCheckProvider(this IServiceCollection services, Action<HealthCheckProviderOptions> configuration)
    {
        var options = HealthCheckProviderOptionsDefaults.Defaults(services);
        configuration(options);
        return services    
            .AddHealthCheckProviderFilters(options)
            .AddHealthCheckProviderGuidanceFilters(options)
            .AddHealthCheckHealthCheckDataBuilders(options)
            .AddOtherRequirements(options)
            .AddBmiProvider(options);
    }

        private static IServiceCollection AddOtherRequirements(this IServiceCollection services, HealthCheckProviderOptions options)
    {
        services.AddTransient<IHealthCheckDataBuilder,HealthCheckDataBuilder>();
        services.AddTransient<HealthCheckDataBuilderProvider>();
        services.AddTransient<BloodPressureProvider>();
        services.AddTransient<IBmiCalculatorProvider, BmiCalculatorProvider>();
        services.AddTransient<IHealthCheckProvider, LoHealthCheckProvider>();
        services.AddTransient<SmokingCalculator>();
        return services;
    }

    private static IServiceCollection AddBmiProvider(this IServiceCollection services, HealthCheckProviderOptions options)
    {
        return services.AddTransient(typeof(IBmiCalculatorProvider),options.BmiProvider);        
    }

    private static IServiceCollection AddHealthCheckProviderFilters(this IServiceCollection services, HealthCheckProviderOptions options)
    {
        return services.AddTransientTypesFrom<IHealthCheckFilter>(options.Filters.Types);        
    }

    private static IServiceCollection AddHealthCheckProviderGuidanceFilters(this IServiceCollection services, HealthCheckProviderOptions options)
    {
        return services.AddTransientTypesFrom<IHealthCheckGuidanceFilter>(options.GuidanceFilters.Types);
    }    

    private static IServiceCollection AddHealthCheckHealthCheckDataBuilders(this IServiceCollection services, HealthCheckProviderOptions options)
    {
        return services.AddTransientTypesFrom<IHealthCheckDataBuilderBuildFilter>(options.HealthCheckDataBuilders.Types);
    }

    private static IServiceCollection AddTransientTypesFrom<T>(this IServiceCollection services, IEnumerable<Type> types)
    {
        foreach(var t in types)
        {
            services.AddTransient(typeof(T), t);
        }   

        return services;       
    }        
}
