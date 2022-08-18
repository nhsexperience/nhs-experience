namespace dhc;

public class HealthCheckFilterBmi: IHealthCheckFilter
{
    private readonly IBmiCalculatorProvider _bmiCalculatorProvider;

    public HealthCheckFilterBmi(
        IBmiCalculatorProvider bmiCalculatorProvider
    )
    {
        _bmiCalculatorProvider = bmiCalculatorProvider;
    }

    public HealthCheckResult Update(HealthCheckResult current, HealthCheckData data)
    {

        var bmi = _bmiCalculatorProvider.CalculateBmi(data.BasicObs.Height, data.BasicObs.Mass);
        return current with {Bmi = bmi};
    }
}
