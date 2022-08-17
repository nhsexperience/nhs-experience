namespace dhc;

public class HealthCheckGuidanceFilterWeight: IHealthCheckGuidanceFilter
{
    private readonly BloodPressureProvider _bloodPressureProvider;
    private readonly ILogger<HealthCheckGuidanceFilterWeight> _logger;
    public HealthCheckGuidanceFilterWeight(
        ILogger<HealthCheckGuidanceFilterWeight> logger,
        BloodPressureProvider bloodPressureProvider
    )
    {
        _logger = logger;
        _bloodPressureProvider = bloodPressureProvider;
    }

    public HealthCheckResult Update(HealthCheckResult current, HealthCheckData data)
    {
        if(current.Bmi.BmiDescription!=BmiEnum.Healthy)
        {
            var guidance = current.Guidance;
            var newGuidance = guidance with {WeightGuidance = new HealthCheckResultGuidanceWeight("Weight is not in the Normal zone, guidance is to think about looking into this.")};
            _logger.LogDebug("Setting weight guidance to {weightGuidance}", newGuidance.WeightGuidance.Guidance);
            return current with {Guidance = newGuidance};
        }
        else
        {
            return current;
        }
        
    }
}