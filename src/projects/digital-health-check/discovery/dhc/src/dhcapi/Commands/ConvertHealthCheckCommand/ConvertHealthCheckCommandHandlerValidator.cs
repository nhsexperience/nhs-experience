using FluentValidation;

namespace dhcapi;

public class ConvertHealthCheckCommandHandlerValidator : AbstractValidator<ConvertHealthCheckCommand>
{
    public ConvertHealthCheckCommandHandlerValidator()
    {
        RuleFor(x=> x.RequestData.AgeDays).GreaterThan(3650);
        RuleFor(x=> x.RequestData.Systolic).GreaterThan(0);
        RuleFor(x=> x.RequestData.Diastolic).GreaterThan(0);
    }
}