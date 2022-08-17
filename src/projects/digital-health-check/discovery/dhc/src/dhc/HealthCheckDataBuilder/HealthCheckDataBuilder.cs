using dhc;
using UnitsNet;

namespace dhc;


public class HealthCheckDataBuilder : IHealthCheckDataBuilder
{

    Stack<HealthCheckDataBuilderData> _datas = new Stack<HealthCheckDataBuilderData>();
    IEnumerable<IHealthCheckDataBuilderBuildFilter> _filters;
    public HealthCheckDataBuilder(IEnumerable<IHealthCheckDataBuilderBuildFilter> filters)
    {
        var d1= default(HealthCheckDataBuilderData);
        var d2 = d1  with {Keys=new string[0], Values= new object[0]};
        _datas.Push(d2);
        _filters = filters;
    }

    public HealthCheckDataBuilder KeyValue<T>(string key, T value)
        where T : struct
    {
        var data  =_datas.Peek();
        var newData = data.SetValue(key, value);
        _datas.Push(newData);
        return this;

    }
    
    public HealthCheckDataBuilder Age(int days)
    {
        return KeyValue("AgeDays", days);
    }

    public HealthCheckDataBuilder Mass(double kg)
    {
        return KeyValue("MassKg", kg);
    }

    public HealthCheckDataBuilder Height(double meters)
    {
        return KeyValue("HeightM", meters);
    }   

    public HealthCheckDataBuilder Systolic(double systolic)
    {
        return KeyValue("Systolic", systolic);
    }    

    public HealthCheckDataBuilder Diastolic(double diastolic)
    {
        return KeyValue("Diastolic", diastolic);
    }            

    public HealthCheckData Build()
    {
        var data = _datas.Peek();
        var currentOutput = default(HealthCheckData);

        if(_filters!=null)
        {
            foreach(var filter in _filters)
            {
                currentOutput = filter.Filter(currentOutput, data);
            }
        }
        return currentOutput;
    }
}