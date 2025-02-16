namespace Belly.Algorithm.LeetCode;

public class RandomizedCollection
{
    private readonly Dictionary<int, HashSet<int>> dict;
    private readonly List<int> list;

    public RandomizedCollection()
    {
        this.dict = [];
        this.list = [];
    }

    public bool Insert(int val)
    {
        HashSet<int> set = dict.GetValueOrDefault(val, []);
        set.Add(list.Count);
        list.Add(val);
        return set.Count == 1;
    }

    public bool Remove(int val)
    {
        if (!dict.ContainsKey(val))
        {
            return false;
        }
        int index = dict[val].First();
        dict[val].Remove(index);
        if (dict[val].Count == 0)
        {
            dict.Remove(val);
        }
        int last = list.Last();
        list[index] = last;
        dict[last].Add(index);
        dict[last].Remove(list.Count - 1);
        list.RemoveAt(list.Count - 1);
        return true;
    }

    public int GetRandom()
    {
        return this.list[Random.Shared.Next(list.Count)];
    }
}
