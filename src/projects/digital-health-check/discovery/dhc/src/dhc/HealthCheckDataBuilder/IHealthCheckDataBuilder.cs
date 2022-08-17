namespace dhc;

public interface IHealthCheckDataBuilder : IHealthCheckDataBuilderDemographics, IHealthCheckDataBuilderBloodPressure, IHealthCheckDataBuilderBuild
{
     HealthCheckDataBuilder KeyValue<T>(string key, T value) where T : struct;
}
