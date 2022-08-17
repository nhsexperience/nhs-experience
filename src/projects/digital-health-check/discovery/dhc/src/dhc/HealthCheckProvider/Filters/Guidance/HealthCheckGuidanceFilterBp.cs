namespace dhc;

public class HealthCheckGuidanceFilterBp: IHealthCheckGuidanceFilter
{
    private readonly BloodPressureProvider _bloodPressureProvider;
    private readonly ILogger<HealthCheckGuidanceFilterWeight> _logger;

    public HealthCheckGuidanceFilterBp(
        BloodPressureProvider bloodPressureProvider,
        ILogger<HealthCheckGuidanceFilterWeight> logger
    )
    {
        _bloodPressureProvider = bloodPressureProvider;
        _logger = logger;
    }

    public HealthCheckResult Update(HealthCheckResult current, HealthCheckData data)
    {
        if(current.BloodPressure.BloodPressureDescription!="Normal")
        {
            var guidance = current.Guidance;
            var newGuidance = guidance with {BloodPressureGuidance = new HealthCheckResultGuidanceBloodPressure("BP is not in the Normal zone, guidance is to think about looking into this.")};
            _logger.LogDebug("Setting blood pressure guidance to {bloodPressureGuidance}", newGuidance.BloodPressureGuidance.Guidance);
            return current with {Guidance = newGuidance};
        }
        else
        {
            return current;
        }
        
    }
}