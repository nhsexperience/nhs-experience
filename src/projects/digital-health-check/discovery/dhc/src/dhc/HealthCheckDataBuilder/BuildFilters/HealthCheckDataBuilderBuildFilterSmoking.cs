namespace dhc;

public class HealthCheckDataBuilderBuildFilterSmoking: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {SmokingData =  new SmokingData(
            inputData.GetValue<int>("CigarettesPerDay"),
            inputData.GetValue<bool>("UsedToSmoke"))};        
    }
}
