namespace dhc;

public interface IHealthCheckDataBuilderBuildFilter
{
    HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData);
}
