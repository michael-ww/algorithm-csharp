namespace Algorithm.LeetCode;

public class LeetCode199
{
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> answer = new List<int>();
        if (root == null)
        {
            return answer;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode tr = queue.Dequeue();
                if (i == size - 1)
                {
                    answer.Add(tr.Value);
                }
                if (tr.Left is not null)
                {
                    queue.Enqueue(tr.Left);
                }
                if (tr.Right is not null)
                {
                    queue.Enqueue(tr.Right);
                }
            }
        }

        return answer;
    }
}
