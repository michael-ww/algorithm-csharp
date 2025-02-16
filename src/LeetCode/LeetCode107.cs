namespace Belly.Algorithm.LeetCode;

public class LeetCode107
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        ArgumentNullException.ThrowIfNull(root);
        List<IList<int>> answer = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            List<int> level = new();
            for (int i = levelCount; i > 0; i--)
            {
                TreeNode tn = queue.Dequeue();
                level.Add(tn.Value);
                if (tn.Left is not null)
                {
                    queue.Enqueue(tn.Left);
                }
                if (tn.Right is not null)
                {
                    queue.Enqueue(tn.Right);
                }
            }
            answer.Add(level);
        }
        answer.Reverse();
        return answer;
    }
}
