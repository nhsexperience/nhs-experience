using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace bpapi.Controllers;

[ApiController]
[ApiVersion("0.1")]
[ApiVersion("0.2")]
[Route("/v{version:apiVersion}/[controller]")]
public class BloodPressureController : ControllerBase
{

    private readonly ILogger<BloodPressureController> _logger;
    private readonly BloodPressureProvider _bpProvider;
    public BloodPressureController(
        ILogger<BloodPressureController> logger, 
        BloodPressureProvider bpProvider)
    {
        _logger = logger;
        _bpProvider = bpProvider;
    }

    /// <summary>
    /// Retrieves a Blood Pressure result
    /// </summary>
    /// <remarks>Awesomeness!</remarks>
    /// <param name="systolic" example="100">The systolic (top)</param>
    /// <param name="diastolic" example="75">The diastolic (bottom)</param>
    /// <response code="200" example="Normal">BP result retrieved</response>
    /// <example>Normal 1234</example>
    [Produces("text/plain")]
    [HttpGet("{systolic}/{diastolic}", Name = "GetBloodPressure"), MapToApiVersion("0.1")]
    [ProducesResponseType(typeof(string), 200)]
    public ActionResult<string> Get(double systolic, double diastolic)
    {
        var result = BloodPressureResultConverter.GetResult(systolic, diastolic);
        _logger.LogTrace("V0.1 BP Result of {result} for {systolic} over {diastolic}", result, systolic, diastolic);
        return result.ToString();
    }
    

    /// <param name="systolic" example="100"></param>
    /// <param name="diastolic" example="99"></param>
    [SwaggerOperation(
        Summary = "Retrieves a Blood Pressure result.",
        Description = "Returns a text representation of the Blood Pressure results from the provided values.",
        OperationId = "GetBpResult",
        Tags = new[] { "BloodPressure" })]
    [SwaggerResponse(StatusCodes.Status200OK, "The blood pressure result was returned", typeof(BloodPressureResult))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "An error generating the blood pressure result.")]
    [Produces("application/json")]
    [HttpGet("{systolic}/{diastolic}", Name = "GetBloodPressure"), MapToApiVersion("0.2")]
    public ActionResult<BloodPressureResult> GetV2(
        [SwaggerParameter("The systolic (top)", Required = true)]int systolic, 
        [SwaggerParameter("The diastolic (bottom)", Required = true)]int diastolic)
    {
        var bpResult = _bpProvider.CalculateBloodPressure(systolic,diastolic);
        _logger.LogTrace("V0.2 BP Result of {result} for {systolic} over {diastolic}", bpResult.BloodPressureDescription, systolic, diastolic);
        if(bpResult.BloodPressureDescription == "Error")
            return BadRequest();

        return new BloodPressureResult(bpResult.BloodPressureDescription, systolic, diastolic );
    }
}
