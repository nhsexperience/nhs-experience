namespace dhc;

public interface IHealthCheckProvider
{
    HealthCheckResult Calculate(HealthCheckData value);
}
