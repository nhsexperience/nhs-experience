namespace dhc;

public class HealthCheckGuidanceFilterSmoking: IHealthCheckGuidanceFilter
{
    private readonly BloodPressureProvider _bloodPressureProvider;
    private readonly ILogger<HealthCheckGuidanceFilterSmoking> _logger;
    public HealthCheckGuidanceFilterSmoking(
        ILogger<HealthCheckGuidanceFilterSmoking> logger,
        BloodPressureProvider bloodPressureProvider
    )
    {
        _logger = logger;
        _bloodPressureProvider = bloodPressureProvider;
    }

    public HealthCheckResult Update(HealthCheckResult current, HealthCheckData data)
    {
        if(current.Smoking.PerDay>0)
        {
            var guidance = current.Guidance;
            var newGuidance = guidance with {SmokingGuidance = new SmokingGuidance($"You smoke at a level of {current.Smoking.Description}, guidance is to think about looking into this.")};
            _logger.LogDebug("Setting smoking guidance to {smokingGuidance}", newGuidance.WeightGuidance.Guidance);
            return current with {Guidance = newGuidance};
        }
        else
        {
            return current;
        }
        
    }
}