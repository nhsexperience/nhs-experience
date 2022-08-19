namespace dhc;

public readonly record struct HealthCheckResult(BloodPressure BloodPressure, Bmi Bmi, SmokingResult Smoking, HealthCheckResultGuidance Guidance);
