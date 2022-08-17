namespace dhc;


public readonly record struct HealthCheckDataBuilderData(string[] Keys, object[] Values)
{
    public object GetValue(string key)
    {
        var keyIndex = Array.IndexOf(Keys, key);
        if(keyIndex>=0)
        {
            return Values[keyIndex];
        }
        throw new Exception("Not found");
    } 

    public HealthCheckDataBuilderData SetValue<T>(string key, T value)
        where T: struct
    {
        var data  = this;
        var keys = data.Keys;
        var values = data.Values;
        var keyIndex = Array.IndexOf(keys, key);
        if(keyIndex>=0)
        {
            values[keyIndex] = value;
        }
        else
        {
            keys = keys.Append(key).ToArray();            
            values = values.Append(value).ToArray();
        }
        var newData = data with {Keys=keys, Values=values}; 
        return newData;       
    }
}