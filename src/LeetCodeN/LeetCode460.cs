namespace Algorithm.LeetCode;

public class LFUCache
{
    private readonly int capacity;
    private readonly Dictionary<int, Node> data;
    private readonly SortedSet<Node> visited;
    public LFUCache(int capacity)
    {
        this.capacity = capacity;
        this.data = [];
        this.visited = [];
    }

    public int Get(int key)
    {
        if (this.data.TryGetValue(key, out Node value))
        {
            if (this.visited.TryGetValue(value, out Node av))
            {
                this.visited.Remove(value);
                av.Count++;
                av.Time = DateTimeOffset.UnixEpoch.TotalOffsetMinutes;
                this.visited.Add(av);
            }
            return value.Value;
        }
        else
        {
            return default;
        }
    }

    public void Put(int key, int value)
    {

    }

    class Node
    {
        public int Key { get; }
        public int Value { get; }
        public int Count { get; set; }
        public int Time { get; set; }

        public int Compare(Node x, Node y)
        {
            return x.Count == y.Count ? x.Time - y.Time : x.Count - y.Count;
        }

        public override int GetHashCode()
        {
            return this.Count * 1000000007 + this.Time;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj is Node)
            {
                Node node = obj as Node;
                return this.Key == node.Key;
            }

            return false;
        }
    }
}
