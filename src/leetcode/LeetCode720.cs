namespace Algorithm.LeetCode;

public class LeetCode720
{
    public string LongestWord(string[] words)
    {
        ArgumentNullException.ThrowIfNull(words);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(words.Length);

        TrieNode root = this.BuildTrie(words);
        string answer = string.Empty;
        foreach (var item in words)
        {
            if (this.Search(root, item))
            {
                if (item.Length > answer.Length)
                {
                    answer = item;
                }
                else if (item.Length == answer.Length)
                {
                    answer = answer.CompareTo(item) > 0 ? item : answer;
                }
            }
        }
        return answer;
    }

    private bool Search(TrieNode root, string word)
    {
        TrieNode current = root;
        foreach (var ch in word)
        {
            if (!current.Nexts.ContainsKey(ch) || current.Nexts[ch].End <= 0)
            {
                return false;
            }
            current = current.Nexts[ch];
        }
        return current.End > 0;
    }

    private TrieNode BuildTrie(string[] words)
    {
        TrieNode root = new();
        TrieNode current = root;
        foreach (var word in words)
        {
            current.Pass++;
            foreach (var item in word)
            {
                if (!current.Nexts.ContainsKey(item))
                {
                    current.Nexts.Add(item, new TrieNode());
                }
                current = current.Nexts[item];
            }
            current.End++;
            current.Value = word;
        }
        return root;
    }
}
