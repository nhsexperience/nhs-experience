namespace dhc;

public interface IHealthCheckDataBuilder: IHealthCheckDataBuilderBuild
{
     IHealthCheckDataBuilder KeyValue<T>(string key, T value) where T : struct;
     IHealthCheckDataBuilder KeyValue(string key, string value);
}
