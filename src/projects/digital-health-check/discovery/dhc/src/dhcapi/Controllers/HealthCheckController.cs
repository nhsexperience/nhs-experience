using Microsoft.AspNetCore.Mvc;
using dhc;
using Swashbuckle.AspNetCore.Annotations;

namespace dhcapi.Controllers;

[ApiController]
[ApiVersion("0.1")]
[Route("/v{version:apiVersion}/[controller]")]
public class HealthCheckController : ControllerBase
{
    private readonly ILogger<HealthCheckController> _logger;
    private readonly  HealthCheckProvider _healthCheckProvider;
    private readonly HealthCheckDataBuilderProvider _hcBuilderProvider;
    public HealthCheckController(
        ILogger<HealthCheckController> logger,
        HealthCheckProvider healthCheckProvider,
         HealthCheckDataBuilderProvider hcBuilderProvider)
    {
        _logger = logger;
        _healthCheckProvider = healthCheckProvider;
        _hcBuilderProvider = hcBuilderProvider;
    }

    [Consumes("application/json")]
    [Produces("application/json")]
    [HttpPost(Name = "GetHealthCheck"), MapToApiVersion("0.1")]
    public HealthCheckResult Get(
          [FromBody]HealthCheckRequestData data)
    {
        var builder = _hcBuilderProvider.Create();
         var healthCheckData = builder
            .Age(data.AgeDays)
            .Mass(data.MassKg)
            .Height(data.HeightM)
            .Systolic(data.Systolic)
            .Diastolic(data.Diastolic)
            .KeyValue("testing", 123)
            .KeyValue("testing2", 123.3)
            .KeyValue("testing", 123456789)
            .Build();
    
   
        return _healthCheckProvider.Calculate(healthCheckData);
    }
}
