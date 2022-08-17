using dhc;
using UnitsNet;

namespace dhc;

public class HealthCheckDataBuilder
{
    int _ageDays;
    double _massKg;
    double _heightM;
    double _systolic;
    double _diastolic;

    public HealthCheckDataBuilder Age(int days)
    {
        _ageDays = days;
        return this;
    }

    public HealthCheckDataBuilder Mass(double kg)
    {
        _massKg = kg;
        return this;
    }

    public HealthCheckDataBuilder Height(double meters)
    {
        _heightM = meters;
        return this;
    }   

    public HealthCheckDataBuilder Systolic(double systolic)
    {
        _systolic = systolic;
        return this;
    }    

    public HealthCheckDataBuilder Diastolic(double diastolic)
    {
        _diastolic = diastolic;
        return this;
    }            

    public HealthCheckData Build()
    {
        var healthCheckData = new HealthCheckData(
            new HealthCheckDemographicData(UnitsNet.Mass.FromKilograms(_massKg), Length.FromMeters(_heightM), new Age(_ageDays)),
            new BloodPressure(_systolic, _diastolic)
            );

            return healthCheckData;
    }
}