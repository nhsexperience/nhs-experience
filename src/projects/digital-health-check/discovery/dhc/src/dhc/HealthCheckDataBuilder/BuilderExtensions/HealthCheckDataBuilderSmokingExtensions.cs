namespace dhc;

public static class HealthCheckDataBuilderSmokingExtensions
{
    public static IHealthCheckDataBuilder CigarettesPerDay(this IHealthCheckDataBuilder builder, int perDay)
    {
        builder.KeyValue("CigarettesPerDay", perDay);
        return builder;
    }    

   public static IHealthCheckDataBuilder UsedToSmoke(this IHealthCheckDataBuilder builder, bool usedToSmoke)
    {
        builder.KeyValue("UsedToSmoke", usedToSmoke);
        return builder;
    }        

}

