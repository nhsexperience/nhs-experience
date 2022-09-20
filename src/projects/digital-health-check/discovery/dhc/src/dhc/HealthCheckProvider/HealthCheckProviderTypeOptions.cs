using Microsoft.Extensions.DependencyInjection;

namespace dhc;

public class HealthCheckProviderTypeOptions<T>
{
    public HealthCheckProviderTypeOptions(
        IServiceCollection services,
        HealthCheckProviderOptions baseOptions)
    {
        Services = services;
        BaseOptions = baseOptions;
    }
    public HealthCheckProviderOptions BaseOptions {get; init;}
    public IServiceCollection Services {get; init;}

    private IList<Type> _types = new List<Type>();
    public IEnumerable<Type> Types => _types;
    public HealthCheckProviderOptions Clear()
    {
        _types.Clear();
        return BaseOptions;
    }

   public HealthCheckProviderOptions Add<T>()
    {
        _types.Add(typeof(T));
        return BaseOptions;
    }        
}
