using Microsoft.Extensions.Logging;

namespace dhc;

public class BmiCalculatorProvider
{
    private readonly ILogger<BmiCalculatorProvider> _logger;

    public BmiCalculatorProvider(ILogger<BmiCalculatorProvider> logger)
    {
        _logger = logger;
    }

    public Bmi CalculateBmi(Height height, Mass mass)
    {
        _logger.LogDebug("Height {heightcm} cm", height.cm);
        _logger.LogDebug("Mass {massg} g", mass.grams);        
        var heightM = (decimal)height.cm / (decimal)100;
        var massKg = (decimal)mass.grams / (decimal)1000;
        _logger.LogDebug("Height {heightM} m", heightM);
        _logger.LogDebug("Mass {massKg} kg", massKg);
        var bmi = BmiCalculator.Calculate(height, mass);
        _logger.LogDebug("BMI {bmi}", bmi);
        var bmiObj = new Bmi(bmi);
        _logger.LogDebug("BMI value {bmiValue}", bmiObj.Value);
        _logger.LogDebug("BMI result {bmiResult}", bmiObj.Result);
        return bmiObj;
    }
}
