namespace Belly.Algorithm.LeetCode;

public class LeetCode101
{
    public bool IsSymmetric1(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        return this.IsSymmetric(root.Left, root.Right);
    }

    private bool IsSymmetric(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }
        if (p == null || q == null)
        {
            return false;
        }

        return p.Value == q.Value && this.IsSymmetric(p.Left, q.Right) && this.IsSymmetric(p.Right, q.Left);
    }

    public bool IsSymmetric2(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root.Left);
        queue.Enqueue(root.Right);
        while (queue.Count > 0)
        {
            TreeNode tn1 = queue.Dequeue();
            TreeNode tn2 = queue.Dequeue();
            if (tn1.Value != tn2.Value)
            {
                return false;
            }
            if (tn1.Left != null && tn2.Right != null)
            {
                queue.Enqueue(tn1.Left);
                queue.Enqueue(tn2.Right);
            }
            else
            {
                if ((tn1.Left == null && tn2.Right != null) || (tn1.Left != null && tn2.Right == null))
                {
                    return false;
                }
            }
            if (tn1.Right != null && tn2.Left != null)
            {
                queue.Enqueue(tn1.Right);
                queue.Enqueue(tn2.Left);
            }
            else
            {
                if ((tn1.Right == null && tn2.Left != null) || (tn1.Right != null && tn2.Left == null))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
