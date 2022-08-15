namespace dhc;

public static class BmiCalculator
{
    public static decimal Calculate (Height height, Mass mass)
    {
        var heightM = (decimal)height.cm / (decimal)100;
        var massKg = (decimal)mass.grams / (decimal)1000;   
        var bmi = massKg / (heightM * heightM);     
        return bmi;
    }
}
