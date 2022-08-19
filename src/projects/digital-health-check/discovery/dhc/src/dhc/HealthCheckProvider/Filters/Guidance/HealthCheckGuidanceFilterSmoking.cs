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
        var smokingGuidance =   
            (current.Smoking.SmokingData) switch
            {
                (<=0, true) => new SmokingGuidance($"Great work at quitting smoking, keep it up!"),
                (>0, _) => new SmokingGuidance($"You smoke at a level of {current.Smoking.Description}, guidance is to think about looking into this."),
                _ => current.Guidance.SmokingGuidance
            };
        
        var newGuidance = current.Guidance with {SmokingGuidance = smokingGuidance};
         _logger.LogDebug("Setting smoking guidance to {smokingGuidance}", newGuidance.SmokingGuidance.Guidance);

        return current with {Guidance = newGuidance};

        
    }
}