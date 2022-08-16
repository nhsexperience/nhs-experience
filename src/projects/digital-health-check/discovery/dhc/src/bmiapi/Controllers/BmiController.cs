using Microsoft.AspNetCore.Mvc;
using dhc;
namespace bmiapi.Controllers;

[ApiController]
[ApiVersion("0.1")]
[ApiVersion("0.2")]
[Route("/v{version:apiVersion}/[controller]")]
public class BmiController : ControllerBase
{
    private readonly ILogger<BmiController> _logger;

    public BmiController(ILogger<BmiController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{bmi}/description", Name = "GetBmiDescription"), MapToApiVersion("0.1")]
    public string Get([FromRoute]double bmi)
    {
        var result= BmiResultConverter.GetResult(bmi).ToString();
        _logger.LogTrace("Description of {result} for {bmi}", result, bmi);
        return result;
       
    }
}
