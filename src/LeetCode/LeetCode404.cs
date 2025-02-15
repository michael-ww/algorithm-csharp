namespace Algorithm.LeetCode;

public class LeetCode404
{
    public int SumOfLeftLeaves1(TreeNode root)
    {
        return root == null ? 0 : this.DFS(root, false);
    }

    private int DFS(TreeNode root, bool isLeft)
    {
        int answer = 0;
        if (root == null)
        {
            return 0;
        }

        if (root.Left == null && root.Right == null && isLeft)
        {
            answer += root.Value;
        }

        answer += this.DFS(root.Left, true);
        answer += this.DFS(root.Right, false);
        return answer;
    }

    public int SumOfLeftLeaves2(TreeNode root)
    {
        return root == null ? 0 : this.BFS(root);
    }

    private int BFS(TreeNode root)
    {
        int answer = 0;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode tn = queue.Dequeue();
            if (tn.Left != null)
            {
                if (tn.Left.Left == null && tn.Left.Right == null)
                {
                    answer += tn.Left.Value;
                }
                else
                {
                    queue.Enqueue(tn.Left);
                }
            }
            if (tn.Right != null)
            {
                if (tn.Right.Left != null || tn.Right.Right != null)
                {
                    queue.Enqueue(tn.Right);
                }
            }
        }

        return answer;
    }
}
