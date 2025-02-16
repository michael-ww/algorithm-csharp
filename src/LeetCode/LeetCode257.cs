namespace Belly.Algorithm.LeetCode;

public class LeetCode257
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> answer = new();
        if (root == null)
        {
            return answer;
        }
        this.BinaryTreePaths(root, string.Empty, answer);
        return answer;
    }

    private void BinaryTreePaths(TreeNode root, string path, List<string> answer)
    {
        if (root == null)
        {
            return;
        }
        if (root.Left == null && root.Right == null)
        {
            answer.Add($"{path}{root.Value}");
        }
        else
        {
            this.BinaryTreePaths(root.Left, $"{path}{root.Value}->", answer);
            this.BinaryTreePaths(root.Right, $"{path}{root.Value}->", answer);
        }
    }
}
