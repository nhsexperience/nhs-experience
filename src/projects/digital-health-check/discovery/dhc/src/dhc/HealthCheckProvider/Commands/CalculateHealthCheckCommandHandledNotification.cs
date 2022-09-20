namespace dhc;
using MediatR;

public record CalculateHealthCheckCommandHandledNotification(HealthCheckData HealthCheckData, HealthCheckResult HealthCheckResult): INotification;
