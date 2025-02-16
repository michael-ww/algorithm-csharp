namespace Algorithm.LeetCodeTest;

public class LeetCode662Test
{
    [Fact]
    public void WidthOfBinaryTree_ValidInput_ReturnMaxWidth()
    {
        // Arrange
        TreeNode root = new(1)
        {
            Left = new TreeNode(3)
            {
                Left = new TreeNode(5),
                Right = new TreeNode(3)
            },
            Right = new TreeNode(2)
            {
                Right = new TreeNode(9)
            }
        };
        LeetCode662 solution = new();

        // Act
        int result = solution.WidthOfBinaryTree(root);

        // Assert
        Assert.Equal(4, result);
    }
}
