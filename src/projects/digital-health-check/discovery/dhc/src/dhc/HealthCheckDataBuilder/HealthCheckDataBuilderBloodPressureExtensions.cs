using System.Collections.ObjectModel;
using dhc;
using UnitsNet;

namespace dhc;


public static class HealthCheckDataBuilderBloodPressureExtensions
{
    public static IHealthCheckDataBuilder Systolic(this IHealthCheckDataBuilder builder, double systolic)
    {
        builder.KeyValue("Systolic", systolic);
        return builder;
    }    

    public static IHealthCheckDataBuilder Diastolic(this IHealthCheckDataBuilder builder, double diastolic)
    {
        builder.KeyValue("Diastolic", diastolic);
        return builder;
    }
}
