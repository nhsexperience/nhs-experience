namespace dhc;

public class HealthCheckProvider
{
    private readonly BmiCalculatorProvider _bmiCalculatorProvider;
    private readonly BloodPressureProvider _bloodPressureProvider;

    public HealthCheckProvider(
        BmiCalculatorProvider bmiCalculatorProvider,
        BloodPressureProvider bloodPressureProvider)
    {
        _bmiCalculatorProvider = bmiCalculatorProvider;
        _bloodPressureProvider = bloodPressureProvider;
    }

    public HealthCheckResult Calculate(HealthCheckData value)
    {
        var bmi = _bmiCalculatorProvider.CalculateBmi(value.Demographics.Height, value.Demographics.Mass);
        var bp = _bloodPressureProvider.CalculateBloodPressure(value.BloodPressure.Systolic, value.BloodPressure.Diastolic);
        return new HealthCheckResult(bp, bmi);
    }
}