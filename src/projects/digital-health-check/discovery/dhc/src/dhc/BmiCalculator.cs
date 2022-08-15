

namespace dhc;

public static class BmiCalculator
{
    public static double Calculate (Length height, Mass mass)
    {
        var heightM = height.Meters;
        var massKg = mass.Kilograms;
        var bmi = massKg / (heightM * heightM);     
        return bmi;
    }
}
