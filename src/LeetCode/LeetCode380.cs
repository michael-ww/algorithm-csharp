namespace Belly.Algorithm.LeetCode;

public class RandomizedSet
{
    private readonly Dictionary<int, int> dict;
    private readonly List<int> list;

    public RandomizedSet()
    {
        this.dict = [];
        this.list = [];
    }

    public bool Insert(int val)
    {
        if (this.dict.ContainsKey(val))
        {
            return false;
        }
        this.dict.Add(val, this.list.Count);
        this.list.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!this.dict.ContainsKey(val))
        {
            return false;
        }
        int index = this.dict[val];
        int last = this.list[^1];
        this.list[index] = last;
        this.dict[last] = index;
        this.list.RemoveAt(this.list.Count - 1);
        this.dict.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        return this.list[Random.Shared.Next(this.list.Count)];
    }
}
