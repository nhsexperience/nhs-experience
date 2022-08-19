namespace dhc;

public static class HealthCheckDataBuilderBasicObsExtensions
{
    public static readonly string WaistM = "WaistM";
    public static readonly string MassKg = "MassKg";
    public static readonly string HeightM = "HeightM";

    public static IHealthCheckDataBuilder Waist(this IHealthCheckDataBuilder builder, double meters)
    {
        builder.KeyValue(WaistM, meters);
        return builder;
    }

    public static IHealthCheckDataBuilder Mass(this IHealthCheckDataBuilder builder, double kg)
    {
        builder.KeyValue(MassKg, kg);
        return builder;
    }

    public static IHealthCheckDataBuilder Height(this IHealthCheckDataBuilder builder, double meters)
    {
        builder.KeyValue(HeightM, meters);
        return builder;
    }   
}            
