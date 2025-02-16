namespace Belly.Algorithm.LeetCode;

public class LeetCode100
{
    public bool IsSameTree1(TreeNode p, TreeNode q)
    {
        if (p == null)
        {
            return q == null;
        }
        if (q == null)
        {
            return false;
        }
        if (p.Value != q.Value)
        {
            return false;
        }

        return this.IsSameTree1(p.Left, q.Left) && this.IsSameTree1(p.Right, q.Right);
    }

    public bool IsSameTree2(TreeNode p, TreeNode q)
    {
        if (p == null)
        {
            return q == null;
        }
        if (q == null)
        {
            return false;
        }
        if (p.Value != q.Value)
        {
            return false;
        }

        Queue<TreeNode> pQueue = new();
        pQueue.Enqueue(p);
        Queue<TreeNode> qQueue = new();
        qQueue.Enqueue(q);
        while (pQueue.Count > 0 && qQueue.Count > 0)
        {
            TreeNode ptn = pQueue.Dequeue();
            TreeNode qtn = qQueue.Dequeue();
            if (ptn.Value != qtn.Value)
            {
                return false;
            }
            if ((ptn.Left == null && qtn.Left != null) || (ptn.Left != null && qtn.Left == null))
            {
                return false;
            }
            if ((ptn.Right == null && qtn.Right != null) || (ptn.Right != null && qtn.Right == null))
            {
                return false;
            }
            if (ptn.Left != null)
            {
                pQueue.Enqueue(ptn.Left);
            }
            if (qtn.Left != null)
            {
                qQueue.Enqueue(qtn.Left);
            }
            if (ptn.Right != null)
            {
                pQueue.Enqueue(ptn.Right);
            }
            if (qtn.Right != null)
            {
                qQueue.Enqueue(qtn.Right);
            }
        }

        return pQueue.Count == 0 && qQueue.Count == 0;
    }
}
