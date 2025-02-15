namespace Algorithm.LeetCode;

public class LeetCode117
{
    public TreeNode Connect(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int count = queue.Count;
            for (int i = 1; i <= count; i++)
            {
                TreeNode tn = queue.Dequeue();
                if (i < count)
                {
                    tn.Next = queue.Peek();
                }
                if (tn.Left != null)
                {
                    queue.Enqueue(tn.Left);
                }
                if (tn.Right != null)
                {
                    queue.Enqueue(tn.Right);
                }
            }
        }

        return root;
    }
}
