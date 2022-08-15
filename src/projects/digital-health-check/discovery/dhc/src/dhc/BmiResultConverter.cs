namespace dhc;

public static class BmiResultConverter
{
    public static BmiEnum GetResult(double bmi) =>
        bmi switch
        {
            <  18.5 => BmiEnum.Underweight,
            (>= 18.5) and (<=  24.9) => BmiEnum.Healthy,
            (>= 25) and (<=  29.9) => BmiEnum.Overweight,
            (>= 30) and (<=  39.9) => BmiEnum.Obese,
            >= 40 => BmiEnum.EObese,
            _ => BmiEnum.Unknown
        };
}
