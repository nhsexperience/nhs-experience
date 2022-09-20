namespace bpapi;

/// <summary>
/// A Blood Pressure result
/// </summary>
public readonly record struct BloodPressureResult
{
    public BloodPressureResult(string bloodPressure, int systolic, int diastolic)
    {
        BloodPressure = bloodPressure;
        Systolic = systolic;
        Diastolic = diastolic;
    }
    /// <summary>
    /// The result of the blood pressure.
    /// </summary>
    /// <example>Normal</example>
    public readonly string BloodPressure { get; init; } 

    /// <summary>
    /// The Systolic portion of the blood pressure.
    /// </summary>
    /// <example>100</example>
    public readonly int Systolic { get; init; } 

    /// <summary>
    /// The Diastolic portion of the blood pressure.
    /// </summary>
    /// <example>75</example>    
    public readonly int Diastolic { get; init; }
}