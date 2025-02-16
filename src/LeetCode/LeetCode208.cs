namespace Belly.Algorithm.LeetCode;

public class LeetCode208
{
    private TrieNode Root { get; }

    public LeetCode208()
    {
        this.Root = new();
    }

    public void Insert(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return;
        }

        TrieNode current = Root;
        current.Pass++;
        foreach (var ch in word)
        {
            if (!current.Nexts.ContainsKey(ch))
            {
                current.Nexts.Add(ch, new TrieNode());
            }
            current = current.Nexts[ch];
            current.Pass++;
        }
        current.End++;
    }

    public bool Search(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return false;
        }

        TrieNode current = Root;
        foreach (var ch in word)
        {
            if (!current.Nexts.ContainsKey(ch))
            {
                return false;
            }
            current = current.Nexts[ch];
        }
        return current.End > 0;
    }

    public bool StartsWith(string prefix)
    {
        if (string.IsNullOrWhiteSpace(prefix))
        {
            return false;
        }

        TrieNode current = Root;
        foreach (var ch in prefix)
        {
            if (!current.Nexts.ContainsKey(ch))
            {
                return false;
            }
            current = current.Nexts[ch];
        }

        return current.Pass > 0;
    }

    public void Delete(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return;
        }

        if (!this.Search(word))
        {
            return;
        }

        TrieNode current = Root;
        Root.Pass--;
        foreach (var ch in word)
        {
            if (--current.Nexts[ch].Pass <= 0)
            {
                current.Nexts[ch] = null;
                break;
            }
            current = current.Nexts[ch];
        }
        current.End--;
    }
}
