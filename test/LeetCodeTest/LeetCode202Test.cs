namespace Algorithm.LeetCodeTest;

public class LeetCode202Test
{
    [Fact]
    public void IsHappy_ValidInput_ReturnBoolean()
    {
        // Given
        int n1 = 19;
        int n2 = 2;

        // When
        LeetCode202 leetCode202 = new();
        bool happy1 = leetCode202.IsHappy(n1);
        bool happy2 = leetCode202.IsHappy(n2);

        // Then
        Assert.True(happy1);
        Assert.False(happy2);
    }
}
