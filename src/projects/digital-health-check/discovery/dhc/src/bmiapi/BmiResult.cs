namespace bmiapi;

/// <summary>
/// A BMI result containing numerical and textual description values.
/// </summary>
public readonly record struct BmiResult
{
    public BmiResult(decimal bmi, string bmiDescription)
    {
        Bmi = bmi;
        BmiDescription = bmiDescription;
    }

    /// <summary>
    /// The bmi numerical value.
    /// </summary>
    /// <example>26</example>    
    public readonly decimal Bmi { get; init; }

    /// <summary>
    /// The bmi description.
    /// </summary>
    /// <example>Normal</example>    
    public readonly string BmiDescription { get; init; } 
}