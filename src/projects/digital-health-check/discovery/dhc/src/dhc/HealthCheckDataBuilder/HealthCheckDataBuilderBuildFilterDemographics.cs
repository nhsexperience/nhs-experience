namespace dhc;

public class HealthCheckDataBuilderBuildFilterDemographics: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {Demographics =  new HealthCheckDemographicData(
            UnitsNet.Mass.FromKilograms((double)inputData.GetValue("MassKg")),
             Length.FromMeters((double)inputData.GetValue("HeightM")), 
             new Age((int)inputData.GetValue("AgeDays")))};
    }
}
