namespace dhcapi;

public readonly record struct HealthCheckRequestData(int AgeDays, double MassKg, double HeightM, double Systolic, double Diastolic);
