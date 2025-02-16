namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode404Test
{
    [Fact]
    public void SumOfLeftLeaves_ValidInput_ReturnSum()
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
        LeetCode404 leetCode404 = new();
        int answer1 = leetCode404.SumOfLeftLeaves1(one);
        int answer2 = leetCode404.SumOfLeftLeaves2(one);

        // Then
        Assert.Equal(10, answer1);
        Assert.Equal(10, answer2);
    }
}
