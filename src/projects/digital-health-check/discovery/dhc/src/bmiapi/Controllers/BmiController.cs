using Microsoft.AspNetCore.Mvc;
using dhc;
namespace bmiapi.Controllers;

[ApiController]
[Route("[controller]")]
public class BmiController : ControllerBase
{
    private readonly ILogger<BmiController> _logger;

    public BmiController(ILogger<BmiController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{bmi}/description", Name = "GetBmiDescription")]
    public string Get([FromRoute]double bmi)
    {
        var result= BmiResultConverter.GetResult(bmi).ToString();
        _logger.LogTrace("Description of {result} for {bmi}", result, bmi);
        return result;
       
    }
}
