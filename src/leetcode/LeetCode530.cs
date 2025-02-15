namespace Algorithm.LeetCode;

public class LeetCode530
{
    public int GetMinimumDifference(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int answer = int.MaxValue, previous = int.MinValue;
        this.InorderTraversal(root, ref previous, ref answer);
        return answer;
    }

    private void InorderTraversal(TreeNode root, ref int previous, ref int answer)
    {
        if (root == null)
        {
            return;
        }

        this.InorderTraversal(root.Left, ref previous, ref answer);
        if (previous != int.MinValue && root.Value - previous < answer)
        {
            answer = root.Value - previous;
        }
        previous = root.Value;
        this.InorderTraversal(root.Right, ref previous, ref answer);
    }
}
