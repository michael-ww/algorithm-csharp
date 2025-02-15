namespace Algorithm.LeetCode;

public class LeetCode116
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public TreeNode Connect1(TreeNode root)
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
            for (int i = 0; i < count; i++)
            {
                TreeNode tn = queue.Dequeue();
                if (i < count - 1)
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

    public TreeNode Connect2(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        if (root.Left != null)
        {
            root.Left.Next = root.Right;
            root.Right.Next = root.Next == null ? null : root.Next.Left;
            this.Connect2(root.Left);
            this.Connect2(root.Right);
        }

        return root;
    }
}
