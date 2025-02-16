namespace Belly.Algorithm.LeetCode;

public class SetAllMap
{
    private Dictionary<string, (long, string)> dict;
    private string setAllValue;
    private long setAllTime;

    public SetAllMap()
    {
        dict = [];
        setAllValue = null;
        setAllTime = 0;
    }

    public void Add(string key, string value)
    {
        if (this.dict.TryGetValue(key, out var data))
        {
            this.dict[key] = (DateTimeOffset.Now.UtcTicks, value);
        }
        else
        {
            this.dict.Add(key, (DateTimeOffset.Now.UtcTicks, value));
        }
    }

    public void Remove(string key)
    {
        this.dict.Remove(key);
    }

    public string Get(string key)
    {
        if (this.dict.TryGetValue(key, out var data))
        {
            if (this.setAllTime > data.Item1)
            {
                return this.setAllValue;
            }
            return data.Item2;
        }
        return null;
    }

    public void SetAll(string value)
    {
        this.setAllValue = value;
        this.setAllTime = DateTimeOffset.Now.UtcTicks;
    }

}