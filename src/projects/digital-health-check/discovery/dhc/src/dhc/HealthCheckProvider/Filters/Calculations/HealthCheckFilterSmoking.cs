namespace dhc;

public class HealthCheckFilterSmoking: IHealthCheckFilter
{
    SmokingCalculator _calculator;
    public HealthCheckFilterSmoking(SmokingCalculator calculator)
    {
        _calculator = calculator;
    }
    public HealthCheckResult Update(HealthCheckResult current, HealthCheckData data)
    {
        var smoke = _calculator.Calculate(data.SmokingData.CigarettesPerDay);
        return current with {Smoking = new SmokingResult(data.SmokingData.CigarettesPerDay, smoke)};
    }
}

public class SmokingCalculator
{
    public SmokingDescriptionEnum Calculate(int numberPerDay)
    {
        return 
        (numberPerDay) switch
        {
            < 0 => SmokingDescriptionEnum.ExSmoker,
            0 => SmokingDescriptionEnum.None,
            > 0 and <= 9 => SmokingDescriptionEnum.Light,
            > 9 and <= 19 => SmokingDescriptionEnum.Moderate,
            > 19 and <= 39 => SmokingDescriptionEnum.Heavy,
            > 39 => SmokingDescriptionEnum.VeryHeavy
        };
    }
}

public enum SmokingDescriptionEnum
{
    None,
    Light,
    Moderate,
    Heavy,
    VeryHeavy,
    ExSmoker,
    Error
}
