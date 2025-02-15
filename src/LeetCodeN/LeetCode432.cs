namespace Algorithm.LeetCode;

public class AllOne
{
    private readonly Dictionary<string, Bucket> frequency;
    private readonly Bucket head;
    private readonly Bucket tail;

    public AllOne()
    {
        this.frequency = [];
        this.head = new(0, "");
        this.tail = new(int.MaxValue, "");
        this.head.Next = this.tail;
        this.tail.Last = this.head;
    }

    public void Inc(string key)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            return;
        }
        if (this.frequency.ContainsKey(key))
        {
            Bucket bucket = this.frequency[key];
            if (bucket.Next.Frequency == bucket.Frequency + 1)
            {
                bucket.Next.Add(key);
                this.frequency[key] = bucket.Next;
            }
            else
            {
                Bucket next = new(bucket.Frequency + 1, key);
                bucket.InsertAfter(next);
                this.frequency[key] = next;
            }
            bucket.Remove(key);
            if (bucket.IsEmpty())
            {
                bucket.Remove();
            }
        }
        else
        {
            if (this.head.Next.Frequency == 1)
            {
                this.head.Next.Add(key);
                this.frequency.Add(key, this.head.Next);
            }
            else
            {
                Bucket bucket = new(1, key);
                this.head.InsertAfter(new Bucket(1, key));
                this.frequency.Add(key, bucket);
            }
        }
    }

    public void Dec(string key)
    {
        if (string.IsNullOrWhiteSpace(key) || !this.frequency.ContainsKey(key))
        {
            return;
        }
        Bucket bucket = this.frequency[key];
        if (bucket.Frequency == 1)
        {
            this.frequency.Remove(key);
        }
        else
        {
            if (bucket.Last.Frequency == bucket.Frequency - 1)
            {
                bucket.Last.Add(key);
                this.frequency[key] = bucket.Last;
            }
            else
            {
                Bucket last = new(bucket.Frequency - 1, key);
                bucket.InsertBefore(last);
                this.frequency[key] = last;
            }
        }
        bucket.Remove(key);
        if (bucket.IsEmpty())
        {
            bucket.Remove();
        }
    }

    public string GetMaxKey()
    {
        return this.tail.Last.Get();
    }

    public string GetMinKey()
    {
        return this.head.Next.Get();
    }
}

public class Bucket
{
    public int Frequency { get; }

    public Bucket Last { get; set; }

    public Bucket Next { get; set; }

    private HashSet<string> items { get; }

    public Bucket(int frequency, string key)
    {
        this.Frequency = frequency;
        this.items = new();
        this.items.Add(key);
    }

    public void Add(string item)
    {
        this.items.Add(item);
    }

    public void Remove(string item)
    {
        this.items.Remove(item);
    }

    public string Get()
    {
        if (this.items.Count <= 0)
        {
            return string.Empty;
        }
        return this.items.GetEnumerator().Current;
    }

    public void InsertAfter(Bucket bucket)
    {
        Bucket next = this.Next;
        this.Next = bucket;
        bucket.Last = this;
        bucket.Next = next;
        next.Last = bucket;
    }

    public void InsertBefore(Bucket bucket)
    {
        this.Last.Next = bucket;
        bucket.Last = this.Last;
        bucket.Next = this;
        this.Last = bucket;
    }

    public void Remove()
    {
        this.Last.Next = this.Next;
        this.Next.Last = this.Last;
    }

    public bool IsEmpty()
    {
        return this.items.Count <= 0;
    }
}
