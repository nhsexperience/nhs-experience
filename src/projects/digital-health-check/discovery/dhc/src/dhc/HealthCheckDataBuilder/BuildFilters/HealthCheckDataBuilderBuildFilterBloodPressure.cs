namespace dhc;

public class HealthCheckDataBuilderBuildFilterBloodPressure: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {BloodPressure =  new BloodPressure(
            inputData.GetValue<double>("Systolic"),
            inputData.GetValue<double>("Diastolic"))};        
    }
}
