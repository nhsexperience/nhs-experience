using System.Text.Json.Serialization;
using dhc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.Filters;
using dhcapi;
using UnitsNet;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
.AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddVersionedApiExplorer(setup =>
    {
        setup.GroupNameFormat = "'v'VVV";
        setup.SubstituteApiVersionInUrl = true;
    });
builder.Services.AddApiVersioning(options =>
    {
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ReportApiVersions = true;
        options.DefaultApiVersion = new ApiVersion(0, 2);
    });
builder.Services.AddSwaggerGen(c=>
    {
       
        var filePath = Path.Combine(System.AppContext.BaseDirectory, "dhcapi.xml");
        c.IncludeXmlComments(filePath);
        c.EnableAnnotations();
    });
builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

builder.Services.AddHealthChecks()
    .AddCheck<SampleHealthCheck>("Sample")
    .ForwardToPrometheus();

builder.Services.AddHealthCheckProvider((config)=>
{
    
    //config.SetWebBpProvider(builder.Configuration);
});


//builder.Services.AddHealthCheckProvider((config)=>
//{
//    var o = new BpWebApiSettings();
//    builder.Configuration.GetSection<BpWebApiSettings>(BpWebApiSettings.BpWebApiSettings).Bind(o);
//    config.SetWebBpProvider("http://sln-bpapi-1:5116/");
    // example to clear guidance filters, can then add custom ones if needed.
    //config.GuidanceFilters.Clear();
//});


builder.Services.AddTransient<IHealthCheckRequestDataConverterProvider, HealthCheckRequestDataConverterProvider>();   
//builder.Services.AddRouting();
var app = builder.Build();
var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger(options=>
    {
        
    });
    app.UseSwaggerUI(options=>
    {
        
          var versionDescriptions = provider
                    .ApiVersionDescriptions
                    .OrderByDescending(desc => desc.ApiVersion)
                    .ToList();

        foreach (var description in versionDescriptions)
       {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant()); 
        }
        options.RoutePrefix ="";
    }
    );
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.UseEndpoints(endpoints =>
    {
        endpoints.MapMetrics();
    });

app.MapHealthChecks("/healthz");

app.UseHttpMetrics();

app.Run();
