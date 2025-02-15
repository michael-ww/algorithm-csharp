namespace Algorithm.LeetCode;

public class LeetCode103
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        ArgumentNullException.ThrowIfNull(root);
        List<IList<int>> answer = [];
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        bool leftToRight = true;
        while (queue.Count > 0)
        {
            LinkedList<int> level = new();
            int levelCount = queue.Count;
            for (int i = 0; i < levelCount; i++)
            {
                TreeNode tn = queue.Dequeue();
                if (leftToRight)
                {
                    level.AddLast(tn.Value);
                }
                else
                {
                    level.AddFirst(tn.Value);
                }

                if (tn.Left is not null)
                {
                    queue.Enqueue(tn.Left);
                }
                if (tn.Right is not null)
                {
                    queue.Enqueue(tn.Right);
                }
            }
            leftToRight = !leftToRight;
            answer.Add([.. level]);
        }
        return answer;
    }
}
