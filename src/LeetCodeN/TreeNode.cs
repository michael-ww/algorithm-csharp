namespace Algorithm.LeetCode;

public class TreeNode
{
    public int Value { get; set; }

    public TreeNode Left { get; set; }

    public TreeNode Right { get; set; }

    public TreeNode Next { get; set; }

    public TreeNode Parent { get; set; }

    public TreeNode(int value) { this.Value = value; }
}
