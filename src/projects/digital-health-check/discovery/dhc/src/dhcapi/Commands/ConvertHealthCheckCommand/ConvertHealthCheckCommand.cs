using MediatR;
namespace dhcapi;

public record ConvertHealthCheckCommand(HealthCheckRequestData RequestData):  IRequest<HealthCheckData>;

