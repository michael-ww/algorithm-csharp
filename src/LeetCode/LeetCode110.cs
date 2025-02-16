namespace Belly.Algorithm.LeetCode;

public class LeetCode140
{
    public bool IsBalanced(TreeNode root)
    {
        return this.Process(root).Item1;
    }

    private (bool, int) Process(TreeNode root)
    {
        if (root == null)
        {
            return (true, 0);
        }
        (bool isLeftBalanced, int leftHeight) = this.Process(root.Left);
        (bool isRightBalanced, int rightHeight) = this.Process(root.Right);
        int height = Math.Max(leftHeight, rightHeight) + 1;
        bool isBalanced = isLeftBalanced && isRightBalanced && Math.Abs(leftHeight - rightHeight) <= 1;
        return (isBalanced, height);
    }
}
