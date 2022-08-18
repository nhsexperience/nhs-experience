namespace dhc;

public static class HealthCheckDataBuilderDemographicsExtensions
{

    public static IHealthCheckDataBuilder Age(this IHealthCheckDataBuilder builder, int days)
    {
        builder.KeyValue("AgeDays", days);
        return builder;
    }

    public static IHealthCheckDataBuilder Postcode(this IHealthCheckDataBuilder builder, string postcode)
    {
        builder.KeyValue("Postcode", postcode);
        return builder;
    }    
}   
            
