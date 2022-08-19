namespace dhc;
using Microsoft.Extensions.DependencyInjection;

public class HealthCheckDataBuilderProvider : IHealthCheckDataBuilderProvider
{
    private readonly IServiceProvider _sp;
    public HealthCheckDataBuilderProvider(IServiceProvider sp)
    {
        _sp = sp;
    }

    public IHealthCheckDataBuilder Create()
    {
        return ActivatorUtilities.GetServiceOrCreateInstance<IHealthCheckDataBuilder>(_sp);
    }
}
