namespace dhc;

public readonly record struct HealthCheckData(HealthCheckDemographicData Demographics, HealthCheckBasicObsData BasicObs, BloodPressure BloodPressure, HealthCheckSmokingData SmokingData);
