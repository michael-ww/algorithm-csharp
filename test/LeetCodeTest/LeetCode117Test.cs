namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode117Test
{
    [Fact]
    public void Connect_ValidInput_ReturnRoot()
    {
        // Given
        TreeNode seven = new(7);
        TreeNode six = new(6);
        TreeNode five = new(5);
        TreeNode four = new(4);
        TreeNode three = new(3)
        {
            Left = null,
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
        TreeNode answer = new LeetCode117().Connect(one);

        // Then
        Assert.Equal(seven, answer.Left.Right.Next);
    }
}
