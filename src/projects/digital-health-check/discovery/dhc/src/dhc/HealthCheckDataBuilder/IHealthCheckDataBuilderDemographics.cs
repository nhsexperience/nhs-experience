namespace dhc;

public interface IHealthCheckDataBuilderDemographics
{
    HealthCheckDataBuilder Age(int days);
    HealthCheckDataBuilder Mass(double kg);
    HealthCheckDataBuilder Height(double meters);
}
