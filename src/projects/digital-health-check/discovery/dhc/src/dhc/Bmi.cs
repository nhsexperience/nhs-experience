namespace dhc;

public record Bmi(decimal bmi)
{
    public BmiEnum Result => BmiResultConverter.GetResult(bmi);

    public float Value => (float)Math.Round(bmi,1);
}
