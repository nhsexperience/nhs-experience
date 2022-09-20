namespace dhc;
using MediatR;

public record CalculateHealthCheckCommand(HealthCheckData HealthCheckData):IRequest<HealthCheckResult>;
