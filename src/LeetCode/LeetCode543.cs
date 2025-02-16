namespace Belly.Algorithm.LeetCode;

public class LeetCode543
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        return this.DFS(root).Item1;
    }

    private (int, int) DFS(TreeNode node)
    {
        if (node == null)
        {
            return (0, 0);
        }
        (int leftDiameter, int leftHeight) = this.DFS(node.Left);
        (int rightDiameter, int rightHeight) = this.DFS(node.Right);
        int height = Math.Max(leftHeight, rightHeight) + 1;
        int diameter = Math.Max(leftHeight + rightHeight, Math.Max(leftDiameter, rightDiameter));
        return (diameter, height);
    }
}
