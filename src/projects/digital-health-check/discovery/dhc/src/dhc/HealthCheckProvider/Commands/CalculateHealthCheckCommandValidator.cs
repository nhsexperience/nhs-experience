namespace dhc;
using FluentValidation;

public class CalculateHealthCheckCommandValidator : AbstractValidator<CalculateHealthCheckCommand>
{
    public CalculateHealthCheckCommandValidator()
    {
        RuleFor(x => x.HealthCheckData.BloodPressure.Systolic).GreaterThan(0);
        RuleFor(x => x.HealthCheckData.BloodPressure.Diastolic).GreaterThan(0);
        RuleFor(x => x.HealthCheckData.BasicObs.Height.Meters).GreaterThan(0);
        RuleFor(x => x.HealthCheckData.BasicObs.Waist.Meters).GreaterThan(0);
        RuleFor(x => x.HealthCheckData.BasicObs.Mass.Kilograms).GreaterThan(0);
    }
}
