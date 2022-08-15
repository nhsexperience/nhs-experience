using Microsoft.AspNetCore.Mvc;

namespace bpapi.Controllers;

[ApiController]
[Route("[controller]")]
public class BloodPressureController : ControllerBase
{

    private readonly ILogger<BloodPressureController> _logger;

    public BloodPressureController(ILogger<BloodPressureController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{systolic}/{diastolic}", Name = "GetBloodPressure")]
    public string Get(double systolic, double diastolic)
    {
        var result = BloodPressureResultConverter.GetResult(new BloodPressure(systolic, diastolic));
        _logger.LogTrace("BP Result of {result} for {systolic} over {diastolic}", result, systolic, diastolic);
        return result.ToString();
    }
}
