namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode99Test
{
    [Fact]
    public void RecoverTree1_ValidInput_Succeed()
    {
        // Given
        TreeNode seven = new(7);
        TreeNode six = new(5);
        TreeNode five = new(3);
        TreeNode four = new(1);
        TreeNode three = new(6)
        {
            Left = six,
            Right = seven
        };
        TreeNode two = new(4)
        {
            Left = four,
            Right = five
        };
        TreeNode one = new(2)
        {
            Left = two,
            Right = three
        };

        // When
        LeetCode99 leetCode99 = new();
        leetCode99.RecoverTree1(one);

        // Then
        Assert.Equal(4, one.Value);
    }

    [Fact]
    public void RecoverTree2_ValidInput_Succeed()
    {
        // Given
        TreeNode seven = new(7);
        TreeNode six = new(5);
        TreeNode five = new(3);
        TreeNode four = new(1);
        TreeNode three = new(6)
        {
            Left = six,
            Right = seven
        };
        TreeNode two = new(4)
        {
            Left = four,
            Right = five
        };
        TreeNode one = new(2)
        {
            Left = two,
            Right = three
        };

        // When
        new LeetCode99().RecoverTree2(one);

        // Then
        Assert.Equal(4, one.Value);
    }
}
