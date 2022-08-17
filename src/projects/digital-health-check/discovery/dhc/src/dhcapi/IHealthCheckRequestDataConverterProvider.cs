using dhc;

namespace dhcapi;

public interface IHealthCheckRequestDataConverterProvider
{
    HealthCheckData CovertToDhcHealthCheckData(HealthCheckRequestData data);
}

