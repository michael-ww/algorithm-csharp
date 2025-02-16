namespace Algorithm.LeetCodeTest;

public class LeetCode263Test
{
    [Fact]
    public void IsUgly_ValidInput_ReturnBoolean()
    {
        // Given

        // When
        LeetCode263 leetCode263 = new();
        bool answer1 = leetCode263.IsUgly(2);
        bool answer2 = leetCode263.IsUgly(3);
        bool answer3 = leetCode263.IsUgly(5);
        bool answer4 = leetCode263.IsUgly(6);
        bool answer5 = leetCode263.IsUgly(10);
        bool answer6 = leetCode263.IsUgly(14);

        // Then
        Assert.True(answer1);
        Assert.True(answer2);
        Assert.True(answer3);
        Assert.True(answer4);
        Assert.True(answer5);
        Assert.False(answer6);

    }
}
