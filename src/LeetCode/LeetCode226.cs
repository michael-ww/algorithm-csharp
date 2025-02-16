namespace Belly.Algorithm.LeetCode;

public class LeetCode226
{
    public TreeNode InvertTree1(TreeNode root)
    {
        if (root == null)
        {
            return root;
        }

        TreeNode left = root.Left;
        TreeNode right = root.Right;
        root.Left = this.InvertTree1(right);
        root.Right = this.InvertTree1(left);
        return root;
    }

    public TreeNode InvertTree2(TreeNode root)
    {
        if (root == null)
        {
            return root;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode tn = queue.Dequeue();
            TreeNode temp = tn.Left;
            tn.Left = tn.Right;
            tn.Right = temp;
            if (tn.Left != null)
            {
                queue.Enqueue(tn.Left);
            }
            if (tn.Right != null)
            {
                queue.Enqueue(tn.Right);
            }
        }

        return root;
    }
}
