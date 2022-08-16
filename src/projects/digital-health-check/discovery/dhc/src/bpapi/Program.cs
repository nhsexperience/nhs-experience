using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
        var filePath = Path.Combine(System.AppContext.BaseDirectory, "bpapi.xml");
        c.IncludeXmlComments(filePath);
        c.EnableAnnotations();
    }
);
builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

var app = builder.Build();
var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
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
