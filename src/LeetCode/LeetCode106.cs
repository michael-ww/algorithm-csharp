namespace Belly.Algorithm.LeetCode;

public class LeetCode106
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        ArgumentNullException.ThrowIfNull(inorder);
        ArgumentNullException.ThrowIfNull(postorder);
        ArgumentOutOfRangeException.ThrowIfNotEqual(inorder.Length, postorder.Length);

        Dictionary<int, int> indexes = new();
        for (int i = 0; i < inorder.Length; i++)
        {
            indexes.Add(inorder[i], i);
        }

        return this.BuildTree(indexes, postorder, postorder.Length - 1, 0, postorder.Length - 1);
    }

    private TreeNode BuildTree(Dictionary<int, int> indexes, int[] postorder, int root, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        TreeNode tn = new(postorder[root]);
        int rootIndex = indexes[postorder[root]];
        root--;
        tn.Right = this.BuildTree(indexes, postorder, root, rootIndex + 1, right);
        tn.Left = this.BuildTree(indexes, postorder, root, left, rootIndex - 1);
        return tn;
    }
}
