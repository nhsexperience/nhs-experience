namespace dhc;

public interface IHealthCheckFilter
{
    HealthCheckResult Update(HealthCheckResult current, HealthCheckData data);
}
