namespace dhc;

public interface IBmiCalculatorProvider
{
    Bmi BmiDescription(decimal bmi);
    Bmi CalculateBmi(Length height, Mass mass);
}
