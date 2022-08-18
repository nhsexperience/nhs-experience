namespace dhc;

public readonly record struct HealthCheckResult(BloodPressure BloodPressure, Bmi Bmi, Smoking Smoking, HealthCheckResultGuidance Guidance);

public readonly record struct HealthCheckResultGuidance(HealthCheckResultGuidanceBloodPressure BloodPressureGuidance, HealthCheckResultGuidanceWeight WeightGuidance, SmokingGuidance SmokingGuidance);

public readonly record struct HealthCheckResultGuidanceBloodPressure(string Guidance);

public readonly record struct HealthCheckResultGuidanceWeight(string Guidance);

public readonly record struct Smoking(int PerDay, SmokingDescriptionEnum Description);

public readonly record struct SmokingGuidance(string Guidance);
