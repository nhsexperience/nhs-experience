namespace dhc;

public class HealthCheckProvider : IHealthCheckProvider
{
    private readonly IEnumerable<IHealthCheckFilter> _filters;
    private readonly IEnumerable<IHealthCheckGuidanceFilter> _guidanceFilters;

    private readonly ILogger<HealthCheckProvider> _logger;
    public HealthCheckProvider(
        IEnumerable<IHealthCheckFilter> filters,
        ILogger<HealthCheckProvider> logger,
        IEnumerable<IHealthCheckGuidanceFilter> guidanceFilters)
    {
        _filters = filters;
        _logger = logger;
        _guidanceFilters = guidanceFilters;
    }

    public virtual HealthCheckResult Calculate(HealthCheckData value)
    {
        var current = CalculateResults(value);
        var result = CalculateGuidance(current, value);
        return result;
    }


    public virtual HealthCheckResult CalculateResults(HealthCheckData value)
    {
        _logger.LogDebug("Starting health check calculation on {healthCheckData}", value);
        var current = default(HealthCheckResult);
        foreach (var filter in _filters)
        {
            var filterType = filter.GetType();
            _logger.LogTrace("Running filter {healthCheckFilterName}", filterType);
            _logger.LogTrace("Before running filter {healthCheckFilterName} data is {current}", filterType, current);
            current = filter.Update(current, value);
            _logger.LogTrace("After running filter {healthCheckFilterName} data is {current}", filterType, current);
        }
        _logger.LogDebug("Finished health check calculation on {healthCheckData} with result {healthCheckResult}", value, current);

        return current;
    }

    public virtual HealthCheckResult CalculateGuidance(HealthCheckResult current, HealthCheckData value)
    {
        _logger.LogDebug("Starting health check guidance on {healthCheckData}", value);
        foreach (var filter in _guidanceFilters)
        {
            var filterType = filter.GetType();
            _logger.LogTrace("Running guidance filter {healthCheckFilterName}", filterType);
            _logger.LogTrace("Before running guidance filter {healthCheckFilterName} data is {current}", filterType, current);
            current = filter.Update(current, value);
            _logger.LogTrace("After running guidance filter {healthCheckFilterName} data is {current}", filterType, current);
        }
        _logger.LogDebug("Finished health check guidance on {healthCheckData} with result {healthCheckResult}", value, current);

        return current;
    }    
}
