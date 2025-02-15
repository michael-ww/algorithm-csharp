namespace Algorithm.LeetCode;

public class WordDictionary
{
    private readonly TrieNode root;

    public WordDictionary()
    {
        this.root = new TrieNode();
    }

    public void AddWord(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return;
        }

        TrieNode current = root;
        foreach (var ch in word)
        {
            if (!current.Nexts.ContainsKey(ch))
            {
                current.Nexts.Add(ch, new TrieNode());
            }
            current.Pass++;
            current = current.Nexts[ch];
        }
        current.End++;
    }

    public bool Search(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
        {
            return false;
        }
        return this.DFS(word, 0, root);
    }

    private bool DFS(string word, int index, TrieNode current)
    {
        if (index >= word.Length)
        {
            return current.End > 0;
        }

        if (word[index] == '.')
        {
            foreach (var item in current.Nexts)
            {
                if (!this.DFS(word, index + 1, item.Value))
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            if (!current.Nexts.ContainsKey(word[index]))
            {
                return false;
            }
            current = current.Nexts[word[index]];
            return this.DFS(word, index + 1, current);
        }
    }
}