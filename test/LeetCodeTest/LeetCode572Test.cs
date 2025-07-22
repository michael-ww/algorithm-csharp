namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode572Test
{
    private TreeNode BuildTree(int?[] values)
    {
        if (values == null || values.Length == 0 || values[0] == null) return null;
        var nodes = new TreeNode[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] != null)
                nodes[i] = new TreeNode(values[i].Value);
        }
        for (int i = 0, j = 1; j < values.Length; i++)
        {
            if (nodes[i] == null) continue;
            if (j < values.Length) nodes[i].Left = nodes[j++];
            if (j < values.Length) nodes[i].Right = nodes[j++];
        }
        return nodes[0];
    }

    [Fact]
    public void IsSubtree_SubtreeExists_ReturnsTrue()
    {
        // root:      3
        //           / \
        //          4   5
        //         / \
        //        1   2
        // subRoot: 4
        //         / \
        //        1   2
        var root = BuildTree(new int?[] { 3, 4, 5, 1, 2 });
        var subRoot = BuildTree(new int?[] { 4, 1, 2 });
        var solution = new LeetCode572();
        Assert.True(solution.IsSubtree1(root, subRoot));
    }

    [Fact]
    public void IsSubtree_SubtreeDoesNotExist_ReturnsFalse()
    {
        // root:      3
        //           / \
        //          4   5
        //         / \
        //        1   2
        //             /
        //            0
        // subRoot: 4
        //         / \
        //        1   2
        var root = BuildTree(new int?[] { 3, 4, 5, 1, 2, null, null, 0 });
        var subRoot = BuildTree(new int?[] { 4, 1, 2 });
        var solution = new LeetCode572();
        Assert.False(solution.IsSubtree1(root, subRoot));
    }

    [Fact]
    public void IsSubtree_SubRootIsNull_ReturnsTrue()
    {
        var root = BuildTree(new int?[] { 1 });
        TreeNode subRoot = null;
        var solution = new LeetCode572();
        Assert.True(solution.IsSubtree1(root, subRoot));
    }

    [Fact]
    public void IsSubtree_RootIsNull_SubRootNotNull_ReturnsFalse()
    {
        TreeNode root = null;
        var subRoot = BuildTree(new int?[] { 1 });
        var solution = new LeetCode572();
        Assert.False(solution.IsSubtree1(root, subRoot));
    }

    [Fact]
    public void IsSubtree_BothNull_ReturnsTrue()
    {
        TreeNode root = null;
        TreeNode subRoot = null;
        var solution = new LeetCode572();
        Assert.True(solution.IsSubtree1(root, subRoot));
    }
}