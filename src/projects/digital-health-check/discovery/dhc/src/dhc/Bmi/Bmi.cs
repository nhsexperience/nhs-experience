namespace dhc;

public readonly record struct Bmi(decimal BmiValue)
{
    public readonly BmiEnum BmiDescription => BmiResultConverter.GetResult(BmiValue);
}
