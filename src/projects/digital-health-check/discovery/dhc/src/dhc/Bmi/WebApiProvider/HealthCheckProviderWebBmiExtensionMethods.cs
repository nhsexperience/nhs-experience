
namespace dhc;

public static class HealthCheckProviderBmiWebApiProviderExtensionMethods
{
    public static HealthCheckProviderOptions SetWebBpProvider(this HealthCheckProviderOptions options, IConfiguration config)
    {
        var settings = new BpWebApiSettings();
        config.GetSection(BpWebApiSettings.Position).Bind(settings);
        options.Services.Configure<BpWebApiSettings>(config.GetSection(BpWebApiSettings.Position));
        options.SetBmiProvider<WebBmiProvider>();
        options.Services.AddHttpClient<bmiclient.IBmiClient, bmiclient.BmiClient>(c => c.BaseAddress = new Uri(settings.BaseUrl));

        return options;
    }

}
