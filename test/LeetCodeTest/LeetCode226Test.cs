namespace Algorithm.LeetCodeTest;

public class LeetCode226Test
{
    [Fact]
    public void InvertTree_ValidInput_ReturnRoot()
    {
        // Given
        TreeNode seven = new(7);
        TreeNode six = new(6);
        TreeNode five = new(5);
        TreeNode four = new(4);
        TreeNode three = new(3)
        {
            Left = six,
            Right = seven
        };
        TreeNode two = new(2)
        {
            Left = four,
            Right = five
        };
        TreeNode one = new(1)
        {
            Left = two,
            Right = three
        };

        // When
        TreeNode root = new LeetCode226().InvertTree1(one);

        // Then
        Assert.Equal(three, root.Left);
    }
}
