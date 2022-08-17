using Microsoft.Extensions.Logging;

namespace dhc;

public class BloodPressureProvider
{
    private readonly ILogger<BloodPressureProvider> _logger;

    public BloodPressureProvider(ILogger<BloodPressureProvider> logger)
    {
        _logger = logger;
    }

    public BloodPressureResult CalculateBloodPressure(double systolic, double diastolic)
    {
        _logger.LogTrace("Calculating BP result for {systolic}/{diastolic}",systolic,diastolic);
        var bp = new BloodPressure(systolic, diastolic);
        var result = BloodPressureResultConverter.GetResult(bp);
        _logger.LogTrace("Result for BP {systolic}/{diastolic} of {bpResult}",systolic,diastolic,result);
        var returnValue = new BloodPressureResult(bp, result);
        _logger.LogTrace("Calculating BP for {systolic}/{diastolic} returning {bloodPressureResult}",systolic,diastolic, returnValue);
        return returnValue;
    }
}
