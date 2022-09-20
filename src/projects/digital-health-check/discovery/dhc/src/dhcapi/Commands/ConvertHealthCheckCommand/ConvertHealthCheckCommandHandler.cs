using MediatR;

namespace dhcapi;

public class ConvertHealthCheckCommandHandler: IRequestHandler<ConvertHealthCheckCommand, HealthCheckData>
{
    IHealthCheckRequestDataConverterProvider _provider;
    public ConvertHealthCheckCommandHandler(IHealthCheckRequestDataConverterProvider provider)
    {
        _provider = provider;
    }
    public Task<HealthCheckData> Handle(ConvertHealthCheckCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_provider.CovertToDhcHealthCheckData(request.RequestData));
    }
}
