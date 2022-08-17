namespace dhc;

public static class BmiResultConverter
{
    public static BmiEnum GetResult(decimal bmi) =>
        bmi switch
        {
            <  18.5m => BmiEnum.Underweight,
            (>= 18.5m) and (<=  24.9m) => BmiEnum.Healthy,
            (>= 25m) and (<=  29.9m) => BmiEnum.Overweight,
            (>= 30m) and (<=  39.9m) => BmiEnum.Obese,
            >= 40m => BmiEnum.EObese,
            _ => BmiEnum.Unknown
        };
}
