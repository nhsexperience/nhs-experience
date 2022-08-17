namespace dhc;

public static class HealthCheckDataBuilderDemographicsExtensions
{

    public static IHealthCheckDataBuilder Age(this IHealthCheckDataBuilder builder, int days)
    {
        builder.KeyValue("AgeDays", days);
        return builder;
    }
}   
            
