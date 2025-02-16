namespace Algorithm.LeetCodeTest;

public class LeetCode101Test
{
    [Fact]
    public void IsSymmetric_ValidInput_ReturnBool()
    {
        // Given
        TreeNode seven = new(4);
        TreeNode six = new(5);
        TreeNode five = new(5);
        TreeNode four = new(4);
        TreeNode three = new(3)
        {
            Left = six,
            Right = seven
        };
        TreeNode two = new(3)
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
        bool answer1 = new LeetCode101().IsSymmetric1(one);
        bool answer2 = new LeetCode101().IsSymmetric2(one);

        // Then
        Assert.True(answer1);
        Assert.True(answer2);
    }
}
