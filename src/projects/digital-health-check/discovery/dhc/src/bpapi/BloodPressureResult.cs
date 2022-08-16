namespace bpapi;

/// <summary>
/// A Blood Pressure result
/// </summary>
public readonly record struct BloodPressureResult(string bloodPressure, int systolic, int diastolic)
{
    /// <summary>
    /// The result of the blood pressure.
    /// </summary>
    /// <example>Normal</example>
    public string BloodPressure { get; init; } = bloodPressure;

    /// <summary>
    /// The Systolic portion of the blood pressure.
    /// </summary>
    /// <example>100</example>
    public int Systolic { get; init; } = systolic;

    /// <summary>
    /// The Diastolic portion of the blood pressure.
    /// </summary>
    /// <example>75</example>    
    public int Diastolic { get; init; } = diastolic;
}