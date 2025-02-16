namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode107Test
{
    [Fact]
    public void LevelOrderBottom_ValidInput_ReturnLevelTraversal()
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
        IList<IList<int>> answer = new LeetCode107().LevelOrderBottom(one);

        // Then
        Assert.Equal(3, answer.Count);
        Assert.Equal(4, answer[0].Count);
        Assert.Equal(4, answer[0][0]);

    }
}
