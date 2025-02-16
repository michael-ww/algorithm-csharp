namespace Belly.Algorithm.LeetCode;

public class Trie
{
    private TrieNode Root { get; }

    public Trie()
    {
        this.Root = new();
    }

    public void Insert(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return;
        }

        TrieNode current = this.Root;
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

    public int Search(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return 0;
        }

        TrieNode current = this.Root;
        foreach (var ch in word)
        {
            if (!current.Nexts.ContainsKey(ch))
            {
                return 0;
            }
            current = current.Nexts[ch];
        }
        return current.End;
    }

    public int StartWith(string prefix)
    {
        if (string.IsNullOrWhiteSpace(prefix))
        {
            return 0;
        }

        TrieNode current = this.Root;
        foreach (var ch in prefix)
        {
            if (!current.Nexts.ContainsKey(ch))
            {
                return 0;
            }

            current = current.Nexts[ch];
        }
        return current.Pass;
    }

    public void Delete(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return;
        }
        if (this.Search(word) > 0)
        {
            TrieNode current = this.Root;
            current.Pass--;
            foreach (var ch in word)
            {
                if (--current.Nexts[ch].Pass <= 0)
                {
                    current.Nexts.Remove(ch);
                    return;
                }
                current = current.Nexts[ch];
            }
            current.End--;
        }
    }
}