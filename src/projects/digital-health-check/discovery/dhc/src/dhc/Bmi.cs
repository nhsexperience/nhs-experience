namespace dhc;

public record Bmi(double bmi)
{
    public BmiEnum Result => BmiResultConverter.GetResult(bmi);

    public float Value => (float)Math.Round(bmi,1);
}
