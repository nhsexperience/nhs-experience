using Microsoft.AspNetCore.Mvc;

namespace bpapi.Controllers;

[ApiController]
[ApiVersion("0.1")]
[ApiVersion("0.2")]
[Route("/v{version:apiVersion}/[controller]")]
public class BloodPressureController : ControllerBase
{

    private readonly ILogger<BloodPressureController> _logger;

    public BloodPressureController(ILogger<BloodPressureController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{systolic}/{diastolic}", Name = "GetBloodPressure"), MapToApiVersion("0.1")]
    public string Get(double systolic, double diastolic)
    {
        var result = BloodPressureResultConverter.GetResult(new BloodPressure(systolic, diastolic));
        _logger.LogTrace("V0.1 BP Result of {result} for {systolic} over {diastolic}", result, systolic, diastolic);
        return result.ToString();
    }
    
    [HttpGet("{systolic}/{diastolic}", Name = "GetBloodPressure"), MapToApiVersion("0.2")]
    public string GetV1(double systolic, double diastolic)
    {
        var result = BloodPressureResultConverter.GetResult(new BloodPressure(systolic, diastolic));
        _logger.LogTrace("V0.2 BP Result of {result} for {systolic} over {diastolic}", result, systolic, diastolic);
        return result.ToString();
    }
}
