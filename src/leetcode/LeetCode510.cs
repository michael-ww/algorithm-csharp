namespace Algorithm.LeetCode;

public class LeetCode510
{
    public TreeNode InorderSuccessor(TreeNode node)
    {
        if (node == null)
        {
            return null;
        }

        if (node.Right == null)
        {
            TreeNode current = node.Parent;
            while (current != null && current.Value < node.Value)
            {
                current = current.Parent;
            }
            return current;
        }
        else
        {
            TreeNode current = node.Right;
            while (current != null && current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }
    }
}
