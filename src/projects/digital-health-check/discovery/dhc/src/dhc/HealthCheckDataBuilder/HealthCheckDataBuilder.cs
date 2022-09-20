using System.Collections.ObjectModel;
using dhc;
using UnitsNet;

namespace dhc;


public class HealthCheckDataBuilder : IHealthCheckDataBuilder
{

    protected readonly Stack<HealthCheckDataBuilderData> _datas = new Stack<HealthCheckDataBuilderData>();
    protected readonly ILogger<HealthCheckDataBuilder> _logger;
    protected readonly IEnumerable<IHealthCheckDataBuilderBuildFilter> _filters;
    public HealthCheckDataBuilder(
        ILogger<HealthCheckDataBuilder> logger,
        IEnumerable<IHealthCheckDataBuilderBuildFilter> filters) : this(filters)
    {
        _logger = logger;
    }

    protected HealthCheckDataBuilder(IEnumerable<IHealthCheckDataBuilderBuildFilter> filters) : this()
    {
        _filters = filters;        
    }

    private HealthCheckDataBuilder()
    {     
        var d1= default(HealthCheckDataBuilderData);
        var d2 = d1  with {Keys=new string[0], Values= new object[0]};
        _datas.Push(d2);
    }



    public IHealthCheckDataBuilder KeyValue<T>(string key, T value)
        where T : struct
    {
        var data  =GetLatest();
        var newData = data.SetValue(key, value);
        SetLatest(newData);
        return this;
    }

    public IHealthCheckDataBuilder KeyValue(string key, string value)
    {
        var data  =GetLatest();
        var newData = data.SetValue(key, value);
        SetLatest(newData);
        return this;
    } 


    private HealthCheckDataBuilderData GetLatest()
    {
        return _datas.Peek();
    } 

    private void SetLatest(HealthCheckDataBuilderData newData)
    {
        var latest = GetLatest();
        var latestHash=latest.GetHashCode();
        var newDataHash=newData.GetHashCode();
        if(latest==newData)
        {
            _logger.LogDebug("HealthCheckDataBuilderData not changed from {latestData} to {newData}", latest, newData);
        }
        else
        {
            _logger.LogTrace("HealthCheckDataBuilderData updated from {latestData} to {newData}", latest, newData);            
        }
        _datas.Push(newData);
    }             

    public HealthCheckData Build()
    {
        var data = _datas.Peek();
        
        _logger.LogDebug("Building health check data from {builderData}", data);
        if(_logger.IsEnabled(LogLevel.Trace))
        {
            int counter = 0;
            foreach(var history in History())
            {
                counter ++;
                _logger.LogTrace("Health check builder data history {historyNumber} from {builderData}", counter, history);
            }
        }
        var currentOutput = default(HealthCheckData);

        if(_filters!=null)
        {
            _logger.LogDebug("There are {numberOfFilters} filters to run", _filters.Count());
            foreach(var filter in _filters)
            {
                _logger.LogTrace("Running health check builder filter {filterName}", filter.GetType().FullName);
                _logger.LogTrace("Current data before running health check builder filter {filterName} is {currentData}", filter.GetType().FullName, currentOutput);
                currentOutput = filter.Filter(currentOutput, data);
                _logger.LogTrace("Current data after running health check builder filter {filterName} is {currentData}", filter.GetType().FullName, currentOutput);

            }
        }
        return currentOutput;
    }

    public IEnumerable<HealthCheckDataBuilderData> History()
    {
        return Array.AsReadOnly(_datas.Reverse().ToArray());
    }


}