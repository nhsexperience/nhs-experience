namespace dhc;

public class HealthCheckProvider : IHealthCheckProvider
{
    private readonly IEnumerable<IHealthCheckFilter> _filters;

    public HealthCheckProvider(
        IEnumerable<IHealthCheckFilter> filters)
    {

        _filters = filters;
    }

    public HealthCheckResult Calculate(HealthCheckData value)
    {
        var current = default(HealthCheckResult);
        foreach (var filter in _filters)
        {
            current = filter.Update(current, value);
        }

        return current;
    }
}
