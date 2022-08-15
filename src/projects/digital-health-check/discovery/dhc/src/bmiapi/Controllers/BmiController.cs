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

    [HttpGet(Name = "GetBmiDescription")]
    public string Get(decimal bmi)
    {
        return BmiResultConverter.GetResult(bmi).ToString();
       
    }
}
