using System.Text;

namespace dhc;


public readonly record struct HealthCheckDataBuilderData(string[] Keys, object[] Values)  :
    IEquatable<HealthCheckDataBuilderData>
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

    public T  GetValue<T>(string key)
    {
        var keyIndex = Array.IndexOf(Keys, key);
        if(keyIndex>=0)
        {
            return (T)Values[keyIndex];
        }
        throw new Exception("Not found");
    } 

    public HealthCheckDataBuilderData SetValue(string key, decimal value)
    {
        return SetValue(key, value);   
    }

    public HealthCheckDataBuilderData SetValue(string key, float value)
    {
        return SetValue(key, value);   
    }

    public HealthCheckDataBuilderData SetValue(string key, double value)
    {
        return SetValue(key, value);   
    }

    public HealthCheckDataBuilderData SetValue(string key, int value)
    {
        return SetValue(key, value);   
    }

    public HealthCheckDataBuilderData SetValue(string key, string value)
    {
        return SetObject(key, value);   
    }

    public HealthCheckDataBuilderData SetValue<T>(string key, T value)
        where T: struct
    { 
        return SetObject(key, value);       
    }

    private HealthCheckDataBuilderData SetObject(string key, object value)
    {
        var data  = this;
        var keys = (string[])data.Keys.Clone();
        var values = (object[])data.Values.Clone();
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

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("HealthCheckDataBuilderData {");
        for(int i=0;i<Keys.Length;i++)
        {
            sb.Append($"{Keys[i]} = {Values[i]}");
            if(i<Keys.Length-1)
                sb.Append(", ");
        }
        sb.Append("}");        
        return sb.ToString();
    }

    public readonly bool Equals(HealthCheckDataBuilderData other)
    {
        if(Keys.Length!=other.Keys.Length)
            return false;
        
        for(int i=0;i<Keys.Length;i++)
        {
            if(Keys[i]!=other.Keys[i])
                return false;

            if(Values[i]!=other.Values[i])
                return false;                
        }

        return true;
    }

    public override int GetHashCode()
    {
        var hash = 1;

        for(int i=0;i<Keys.Length;i++)
        {
            hash = HashCode.Combine(hash, Keys[i], Values[i]);
        }

        return hash;
    }

}