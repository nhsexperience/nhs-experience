using System.Text.Json.Serialization;
using dhc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.Filters;
using dhcapi;

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

builder.Services.AddTransient<HealthCheckRequestDataConverterProvider>();
builder.Services.AddTransient<IHealthCheckDataBuilderBuildFilter, HealthCheckDataBuilderBuildFilterBasicObs>();
builder.Services.AddTransient<IHealthCheckDataBuilderBuildFilter, HealthCheckDataBuilderBuildFilterDemographics>();
builder.Services.AddTransient<IHealthCheckDataBuilderBuildFilter, HealthCheckDataBuilderBuildFilterBloodPressure>();
builder.Services.AddTransient<IHealthCheckDataBuilder,HealthCheckDataBuilder>();

builder.Services.AddTransient<HealthCheckDataBuilderProvider>();

builder.Services.AddTransient<BloodPressureProvider>();
builder.Services.AddTransient<BmiCalculatorProvider>();

builder.Services.AddTransient<IHealthCheckProvider, HealthCheckProvider>();
builder.Services.AddTransient<IHealthCheckFilter, HealthCheckFilterBp>();
builder.Services.AddTransient<IHealthCheckFilter, HealthCheckFilterBmi>();

builder.Services.AddTransient<IHealthCheckRequestDataConverterProvider, HealthCheckRequestDataConverterProvider>();


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
app.UseAuthorization();
app.MapControllers();
app.Run();
