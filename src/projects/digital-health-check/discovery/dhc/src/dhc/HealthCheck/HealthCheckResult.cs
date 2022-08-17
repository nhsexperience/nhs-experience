namespace dhc;

public readonly record struct HealthCheckResult(BloodPressure BloodPressure, Bmi Bmi, HealthCheckResultGuidance Guidance);

public readonly record struct HealthCheckResultGuidance(HealthCheckResultGuidanceBloodPressure BloodPressureGuidance, HealthCheckResultGuidanceWeight WeightGuidance);

public readonly record struct HealthCheckResultGuidanceBloodPressure(string Guidance);

public readonly record struct HealthCheckResultGuidanceWeight(string Guidance);