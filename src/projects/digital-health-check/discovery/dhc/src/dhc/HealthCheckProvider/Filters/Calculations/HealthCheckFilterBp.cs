namespace dhc;

public class HealthCheckFilterBp: IHealthCheckFilter
{
    private readonly BloodPressureProvider _bloodPressureProvider;

    public HealthCheckFilterBp(
        BloodPressureProvider bloodPressureProvider
    )
    {
        _bloodPressureProvider = bloodPressureProvider;
    }

    public HealthCheckResult Update(HealthCheckResult current, HealthCheckData data)
    {
        var bp = _bloodPressureProvider.CalculateBloodPressure(data.BloodPressure.Systolic, data.BloodPressure.Diastolic);
        return current with {BloodPressure = bp};
    }
}