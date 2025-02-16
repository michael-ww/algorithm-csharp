namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode264Test
{
    [Fact]
    public void NthUglyNumber_ValidInput_ReturnNumber()
    {
        // Given
        int n = 10;

        // When
        int answer = new LeetCode264().NthUglyNumber(n);

        // Then
        Assert.Equal(12, answer);
    }
}
