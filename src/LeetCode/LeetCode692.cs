namespace Belly.Algorithm.LeetCode;

public class LeetCode692
{
    public IList<string> TopKFrequent1(string[] words, int k)
    {
        IList<string> answer = new List<string>();
        if (words == null || words.Length <= 0 || k <= 0)
        {
            return answer;
        }
        Trie trie = new();
        foreach (var item in words)
        {
            trie.Insert(item);
        }

        PriorityQueue<string, KeyValuePair<string, int>> pq = new(Comparer<KeyValuePair<string, int>>.Create((KeyValuePair<string, int> kv1, KeyValuePair<string, int> kv2) =>
        {
            if (kv1.Value != kv2.Value)
            {
                return kv2.Value - kv1.Value;
            }
            else
            {
                return kv1.Key.CompareTo(kv2.Key);
            }
        }));
        foreach (var item in words)
        {
            pq.Enqueue(item, KeyValuePair.Create(item, trie.Search(item)));
        }

        for (int i = 0; i < k; i++)
        {
            answer.Add(pq.Dequeue());
        }

        return answer;
    }
    public IList<string> TopKFrequent2(string[] words, int k)
    {
        IList<string> answer = new List<string>();
        if (words == null || words.Length <= 0 || k <= 0)
        {
            return answer;
        }

        Dictionary<string, int> dictionary = new();
        foreach (var item in words)
        {
            if (dictionary.TryGetValue(item, out int times))
            {
                dictionary[item] = ++times;
            }
            else
            {
                dictionary.Add(item, 1);
            }
        }

        PriorityQueue<string, KeyValuePair<string, int>> pq = new PriorityQueue<string, KeyValuePair<string, int>>(Comparer<KeyValuePair<string, int>>.Create((KeyValuePair<string, int> kv1, KeyValuePair<string, int> kv2) =>
        {
            if (kv2.Value != kv1.Value)
            {
                return kv2.Value - kv1.Value;
            }
            else
            {
                return kv1.Key.CompareTo(kv2.Key);
            }
        }));

        foreach (var item in dictionary)
        {
            pq.Enqueue(item.Key, KeyValuePair.Create(item.Key, item.Value));
        }

        while (pq.Count > 0)
        {
            answer.Add(pq.Dequeue());
        }

        return answer;
    }
}
