namespace dhc;

public class HealthCheckDataBuilderBuildFilterBloodPressure: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {BloodPressure =  new BloodPressure(
            (double)inputData.GetValue("Systolic"),
            (double)inputData.GetValue("Diastolic"))};        
    }
}
