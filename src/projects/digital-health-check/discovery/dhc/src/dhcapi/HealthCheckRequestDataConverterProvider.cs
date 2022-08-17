using dhc;

namespace dhcapi;

public class HealthCheckRequestDataConverterProvider : IHealthCheckRequestDataConverterProvider
{
    private readonly HealthCheckDataBuilderProvider _hcBuilderProvider;

    public HealthCheckRequestDataConverterProvider(HealthCheckDataBuilderProvider hcBuilderProvider)
    {
        _hcBuilderProvider = hcBuilderProvider;
    }

    public HealthCheckData CovertToDhcHealthCheckData(HealthCheckRequestData data)
    {
        var builder = _hcBuilderProvider.Create();

        builder
            .Age(data.AgeDays)
            .Mass(data.MassKg)
            .Height(data.HeightM)
            .Systolic(data.Systolic)
            .Diastolic(data.Diastolic)
            .Waist(data.WaistM)
            .KeyValue("UtcDateTimeCreated", DateTime.UtcNow);

        var healthCheckData = builder.Build();

        return healthCheckData;
    }
}

