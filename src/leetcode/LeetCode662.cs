namespace Algorithm.LeetCode;

public class LeetCode662
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        int answer = 0;
        Queue<(TreeNode, int)> queue = new();
        queue.Enqueue((root, 1));
        while (queue.Count > 0)
        {
            int left = int.MaxValue, right = int.MinValue;
            int currentSize = queue.Count();
            for (int i = 0; i < currentSize; i++)
            {
                (TreeNode item, int index) = queue.Dequeue();
                left = Math.Min(left, index);
                right = Math.Max(right, index);
                if (item.Left is not null)
                {
                    queue.Enqueue((item.Left, index * 2));
                }
                if (item.Right is not null)
                {
                    queue.Enqueue((item.Right, index * 2 + 1));
                }
            }

            answer = Math.Max(answer, right - left + 1);
        }

        return answer;
    }
}
