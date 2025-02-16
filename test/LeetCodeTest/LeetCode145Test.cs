namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode145Test
{
    [Fact]
    public void PostorderTraversal_ValidInput_ReturnList()
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
        LeetCode145 leetCode145 = new();
        IList<int> answer1 = leetCode145.PostorderTraversal1(one);
        IList<int> answer2 = leetCode145.PostorderTraversal2(one);
        IList<int> answer3 = leetCode145.PostorderTraversal3(one);

        // Then
        List<int> expected = new() { 4, 5, 2, 6, 7, 3, 1 };
        Assert.Equal(expected, answer1);
        Assert.Equal(expected, answer2);
        Assert.Equal(expected, answer3);
    }
}
