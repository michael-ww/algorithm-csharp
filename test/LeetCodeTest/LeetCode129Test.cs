namespace Algorithm.LeetCodeTest;

public class LeetCode129Test
{
    [Fact]
    public void SumNumbers_ValidInput_ReturnSum()
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
        int answer = new LeetCode129().SumNumbers(one);

        // Then
        Assert.Equal(522, answer);
    }
}
