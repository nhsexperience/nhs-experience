namespace dhc;

public class HealthCheckDataBuilderBuildFilterBasicObs: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {
        return currentOutput with {BasicObs =  new HealthCheckBasicObsData(
            UnitsNet.Mass.FromKilograms(inputData.GetValue<double>("MassKg")),
            Length.FromMeters(inputData.GetValue<double>("HeightM")), 
            Length.FromMeters(inputData.GetValue<double>("WaistM")))};
    }
}
