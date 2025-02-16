namespace Algorithm.LeetCodeTest;

public class LeetCode100Test
{
    [Fact]
    public void IsSameTree1_ValidInput_ReturnBool()
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

        TreeNode VII = new(7);
        TreeNode VI = new(6);
        TreeNode V = new(5);
        TreeNode IV = new(4);
        TreeNode III = new(3)
        {
            Left = VI,
            Right = VII
        };
        TreeNode II = new(2)
        {
            Left = IV,
            Right = V
        };
        TreeNode I = new(1)
        {
            Left = II,
            Right = III
        };


        // When
        LeetCode100 leetCode100 = new();
        bool answer1 = leetCode100.IsSameTree1(one, I);
        bool answer2 = leetCode100.IsSameTree2(one, I);

        // Then
        Assert.True(answer1);
        Assert.True(answer2);
    }

    [Fact]
    public void IsSameTree2_ValidInput_ReturnBool()
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

        TreeNode VII = new(7);
        TreeNode VI = new(6);
        TreeNode V = new(9);
        TreeNode IV = new(4);
        TreeNode III = new(3)
        {
            Left = VI,
            Right = VII
        };
        TreeNode II = new(2)
        {
            Left = IV,
            Right = V
        };
        TreeNode I = new(1)
        {
            Left = II,
            Right = III
        };


        // When
        LeetCode100 leetCode100 = new();
        bool answer1 = leetCode100.IsSameTree1(one, I);
        bool answer2 = leetCode100.IsSameTree2(one, I);

        // Then
        Assert.False(answer1);
        Assert.False(answer2);
    }
}
