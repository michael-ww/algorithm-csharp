namespace Belly.Algorithm.LeetCode;

public class LeetCode958
{
    public bool IsCompleteBinaryTree(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        bool leafNode = false;
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            if (node.Left == null && node.Right != null)
            {
                return false;
            }
            if (leafNode && (node.Left != null || node.Right != null))
            {
                return false;
            }
            if (node.Left != null)
            {
                queue.Enqueue(node.Left);
            }
            if (node.Right != null)
            {
                queue.Enqueue(node.Right);
            }
            if (node.Left == null || node.Right == null)
            {
                leafNode = true;
            }
        }

        return true;
    }
}