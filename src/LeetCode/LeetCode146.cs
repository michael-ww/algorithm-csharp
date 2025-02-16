namespace Belly.Algorithm.LeetCode;

public class LRUCache<K, V> where K : notnull
{
    private readonly Dictionary<K, V> cache;

    private readonly LinkedList<K> visited;

    private int capacity;

    public LRUCache(int capacity)
    {
        this.cache = new Dictionary<K, V>(2 * capacity - 1);
        this.visited = new LinkedList<K>();
        this.capacity = capacity;
    }

    public V Get(K key)
    {
        if (this.cache.TryGetValue(key, out V value))
        {
            this.visited.Remove(key);
            this.visited.AddFirst(key);
            return value;
        }
        else
        {
            return default;
        }
    }

    public void Put(K key, V value)
    {
        if (this.cache.ContainsKey(key))
        {
            this.visited.Remove(key);
            this.cache[key] = value;
            this.visited.AddFirst(key);
        }
        else
        {
            if (this.cache.Count >= capacity)
            {
                K deleted = this.visited.Last();
                this.cache.Remove(deleted);
                this.visited.Remove(deleted);
            }
            this.cache.Add(key, value);
            this.visited.AddFirst(key);
        }
    }
}
