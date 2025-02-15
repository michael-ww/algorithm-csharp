namespace Algorithm.LeetCode;

public class LeetCode105
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        ArgumentNullException.ThrowIfNull(preorder);
        ArgumentNullException.ThrowIfNull(inorder);
        ArgumentOutOfRangeException.ThrowIfNotEqual(preorder.Length, inorder.Length);

        Dictionary<int, int> indexes = new();
        for (int i = 0; i < inorder.Length; i++)
        {
            indexes.Add(inorder[i], i);
        }
        return this.BuildTree(indexes, preorder, 0, 0, inorder.Length - 1);
    }

    private TreeNode BuildTree(Dictionary<int, int> indexes, int[] preorder, int root, int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        TreeNode tn = new(preorder[root]);
        int rootIndex = indexes[preorder[root]];
        tn.Left = this.BuildTree(indexes, preorder, root + 1, left, rootIndex - 1);
        tn.Right = this.BuildTree(indexes, preorder, root + rootIndex - left + 1, rootIndex + 1, right);
        return tn;
    }
}
