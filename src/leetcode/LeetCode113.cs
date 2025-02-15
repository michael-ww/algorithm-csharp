namespace Algorithm.LeetCode;

public class LeetCode113
{
    public IList<IList<int>> PathSum(TreeNode root, int target)
    {
        List<IList<int>> answer = [];
        this.PathSum(answer, [], root, target);
        return answer;
    }

    private void PathSum(List<IList<int>> answer, IList<int> path, TreeNode root, int target)
    {
        path.Add(root.Value);
        if (root.Left == null && root.Right == null)
        {
            if (root.Value == target)
            {
                answer.Add([.. path]);
            }
        }
        else
        {
            if (root.Left != null)
            {
                this.PathSum(answer, path, root.Left, target - root.Value);
            }
            if (root.Right != null)
            {
                this.PathSum(answer, path, root.Right, target - root.Value);
            }
        }
        path.RemoveAt(path.Count - 1);
    }
}
