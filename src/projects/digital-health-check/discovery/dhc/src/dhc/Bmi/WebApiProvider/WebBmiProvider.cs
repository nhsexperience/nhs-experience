
namespace dhc;



public class WebBmiProvider : IBmiCalculatorProvider
{
    bmiclient.IBmiClient _client;
    IOptions<BpWebApiSettings> _options;
    public WebBmiProvider(bmiclient.IBmiClient client, IOptions<BpWebApiSettings> options)
    {
        _options = options;
        _client = client;
    }
    public Bmi BmiDescription(decimal bmi)
    {
        throw new NotImplementedException();
    }

    public Bmi CalculateBmi(Length height, Mass mass)
    {
        var a = _client.GetBmiAsync(height.Meters, mass.Kilograms);
        var r = a.GetAwaiter().GetResult();
        return new Bmi((decimal)r.Bmi);
    }
}
