namespace Belly.Algorithm.LeetCode;

public class TrieNode
{
    public int Pass { get; set; }

    public int End { get; set; }

    public string Value { get; set; }

    public Dictionary<int, TrieNode> Nexts { get; set; }

    public TrieNode()
    {
        this.Pass = 0;
        this.End = 0;
        this.Nexts = new Dictionary<int, TrieNode>();
    }
}
