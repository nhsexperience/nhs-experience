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
        var smoke = _calculator.Calculate(data.SmokingData.CigarettesPerDay, data.SmokingData.UsedToSmoke);
        return current with {Smoking = new SmokingResult(data.SmokingData, smoke)};
    }
}

public class SmokingCalculator
{
    public SmokingDescriptionEnum Calculate(int numberPerDayNow, bool usedToSmoke)
    {
        return 
        (numberPerDayNow, usedToSmoke) switch
        {
            (<= 0, true)            => SmokingDescriptionEnum.ExSmoker,
            (0, false)              => SmokingDescriptionEnum.None,
            (> 0 and <= 9, _)   => SmokingDescriptionEnum.Light,
            (> 9 and <= 19, _)  => SmokingDescriptionEnum.Moderate,
            (> 19 and <= 39, _) => SmokingDescriptionEnum.Heavy,
            (> 39, _)           => SmokingDescriptionEnum.VeryHeavy
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
