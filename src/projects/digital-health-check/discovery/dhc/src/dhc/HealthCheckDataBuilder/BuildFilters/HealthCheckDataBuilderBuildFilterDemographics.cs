namespace dhc;

public class HealthCheckDataBuilderBuildFilterDemographics: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {Demographics =  new HealthCheckDemographicData(
             new Age(inputData.GetValue<int>("AgeDays")), 
             new Postcode(inputData.GetValue<string>("Postcode")))};
    }
}
