

namespace dhc;

public static class BmiCalculator
{
    public static decimal Calculate (Length height, Mass mass)
    {
        var heightM = height.Meters;
        var massKg = mass.Kilograms;
        var bmi = (decimal)massKg / (decimal) (heightM * heightM);    
        var bmiRounded = Math.Round(bmi, 1); 
        return bmiRounded;
    }
}

