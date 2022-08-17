namespace dhc;

public interface IHealthCheckDataBuilderBloodPressure
{
    HealthCheckDataBuilder Systolic(double systolic);
    HealthCheckDataBuilder Diastolic(double diastolic);   
}
