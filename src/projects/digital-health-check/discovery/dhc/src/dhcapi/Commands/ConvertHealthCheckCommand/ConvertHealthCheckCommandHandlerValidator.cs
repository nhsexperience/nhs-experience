using FluentValidation;

namespace dhcapi;

public class ConvertHealthCheckCommandHandlerValidator : AbstractValidator<ConvertHealthCheckCommand>
{
    public ConvertHealthCheckCommandHandlerValidator()
    {
        RuleFor(x=> x.RequestData.AgeDays).GreaterThan(3650);
        RuleFor(x=> x.RequestData.Systolic).GreaterThan(0);
        RuleFor(x=> x.RequestData.Diastolic).GreaterThan(0);
        RuleFor(x=>x.RequestData.Diastolic2).NotNull().When(x=>x.RequestData.Diastolic3!=null).WithMessage("Diastolic 2 must not be null when Diastolic 3 is provided");

    }
}