namespace dhc;

public interface IHealthCheckGuidanceFilter
{
    HealthCheckResult Update(HealthCheckResult current, HealthCheckData data);
}