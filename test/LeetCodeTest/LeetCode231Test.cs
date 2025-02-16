namespace Algorithm.LeetCodeTest;

public class LeetCode231Test
{
    [Fact]
    public void IsPowerOfTwo_ValidInput_ReturnBoolean()
    {
        // Given

        // When
        LeetCode231 leetCode231 = new();
        bool answer1 = leetCode231.IsPowerOfTwo1(1);
        bool answer2 = leetCode231.IsPowerOfTwo1(16);
        bool answer3 = leetCode231.IsPowerOfTwo1(3);
        bool answer4 = leetCode231.IsPowerOfTwo1(4);
        bool answer5 = leetCode231.IsPowerOfTwo2(1);
        bool answer6 = leetCode231.IsPowerOfTwo2(16);
        bool answer7 = leetCode231.IsPowerOfTwo2(3);
        bool answer8 = leetCode231.IsPowerOfTwo2(4);

        // Then
        Assert.True(answer2);
        Assert.True(answer4);
        Assert.True(answer6);
        Assert.True(answer8);
        Assert.True(answer1);
        Assert.False(answer3);
        Assert.True(answer5);
        Assert.False(answer7);

    }
}
