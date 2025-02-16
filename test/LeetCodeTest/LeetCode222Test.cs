namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode222Test
{
    [Fact]
    public void CountNodes_ValidInput_ReturnCount()
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
        LeetCode222 leetCode222 = new();
        int answer = leetCode222.CountNodes1(one);

        // Then
        Assert.Equal(7, answer);
    }
}
