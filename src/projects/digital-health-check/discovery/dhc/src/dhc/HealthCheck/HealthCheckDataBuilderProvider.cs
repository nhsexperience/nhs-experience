namespace dhc;
using  Microsoft.Extensions.DependencyInjection;
public class HealthCheckDataBuilderProvider
{
    private readonly IServiceProvider _sp;
    public HealthCheckDataBuilderProvider(IServiceProvider sp)
    {
        _sp = sp;
    }

    public HealthCheckDataBuilder Create()
    {
        return ActivatorUtilities.CreateInstance<HealthCheckDataBuilder>(_sp);
    }
}
