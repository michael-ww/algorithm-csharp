namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode367Test
{
    [Fact]
    public void IsPerfectSquare_ValidInput_ReturnBoolean()
    {
        // Given

        // When
        LeetCode367 leetCode367 = new();
        bool answer1 = leetCode367.IsPerfectSquare1(16);
        bool answer2 = leetCode367.IsPerfectSquare1(14);

        // Then
        Assert.True(answer1);
        Assert.False(answer2);
    }
}
