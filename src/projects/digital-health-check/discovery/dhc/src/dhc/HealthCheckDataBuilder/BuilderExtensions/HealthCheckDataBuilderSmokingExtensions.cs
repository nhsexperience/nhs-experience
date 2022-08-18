namespace dhc;

public static class HealthCheckDataBuilderSmokingExtensions
{
    public static IHealthCheckDataBuilder CigarettesPerDay(this IHealthCheckDataBuilder builder, int perDay)
    {
        builder.KeyValue("CigarettesPerDay", perDay);
        return builder;
    }    

}

