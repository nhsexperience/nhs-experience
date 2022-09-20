namespace dhc;

public class HealthCheckDataBuilderBuildFilterBasicObs: IHealthCheckDataBuilderBuildFilter
{
    public  HealthCheckData Filter (HealthCheckData currentOutput, HealthCheckDataBuilderData inputData)
    {        
        return currentOutput with {BasicObs =  new HealthCheckBasicObsData(
            UnitsNet.Mass.FromKilograms(inputData.GetValue<double>(HealthCheckDataBuilderBasicObsExtensions.MassKg)),
            Length.FromMeters(inputData.GetValue<double>(HealthCheckDataBuilderBasicObsExtensions.HeightM)), 
            Length.FromMeters(inputData.GetValue<double>(HealthCheckDataBuilderBasicObsExtensions.WaistM)))};
    }
}
