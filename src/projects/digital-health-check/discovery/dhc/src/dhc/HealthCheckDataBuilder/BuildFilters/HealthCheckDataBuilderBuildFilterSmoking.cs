namespace dhc;

public class HealthCheckDataBuilderBuildFilterSmoking: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {SmokingData =  new HealthCheckSmokingData(
            inputData.GetValue<int>("CigarettesPerDay"))};        
    }
}
