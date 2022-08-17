namespace dhcapi;

public readonly record struct HealthCheckRequestData(int AgeDays, double MassKg, double HeightM, double WaistM, double Systolic, double Diastolic);
