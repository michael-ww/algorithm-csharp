namespace Belly.Algorithm.LeetCode;

public class LeetCode102
{
    public IList<IList<int>> LevelOrder1(TreeNode root)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int nodeCount = queue.Count;
            List<int> nodes = [];
            for (int i = 0; i < nodeCount; i++)
            {
                TreeNode node = queue.Dequeue();
                nodes.Add(node.Value);
                if (node.Left is not null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right is not null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
        return answer;
    }

    public IList<IList<int>> LevelOrder2(TreeNode root)
    {
        IList<IList<int>> answer = [];
        List<int> level = [];
        TreeNode currentEnd = root, nextEnd = null;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            level.Add(node.Value);
            if (node.Left is not null)
            {
                queue.Enqueue(node.Left);
                nextEnd = node.Left;
            }
            if (node.Right is not null)
            {
                queue.Enqueue(node.Right);
                nextEnd = node.Right;
            }
            if (node == currentEnd)
            {
                answer.Add(level);
                currentEnd = nextEnd;
                nextEnd = null;
                level.Clear();
            }
        }

        return answer;
    }
}
