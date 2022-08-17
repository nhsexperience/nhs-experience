using Microsoft.Extensions.Logging;

namespace dhc;

public class BloodPressureProvider
{
    private readonly ILogger<BloodPressureProvider> _logger;

    public BloodPressureProvider(ILogger<BloodPressureProvider> logger)
    {
        _logger = logger;
    }

    public BloodPressure CalculateBloodPressure(double systolic, double diastolic)
    {
        _logger.LogTrace("Calculating BP result for {systolic}/{diastolic}",systolic,diastolic);
        var bp = new BloodPressure(systolic, diastolic);
        _logger.LogTrace("Result for BP {systolic}/{diastolic} of {bpResult}",systolic,diastolic,bp.BloodPressureDescription);
        return bp;
    }
}
