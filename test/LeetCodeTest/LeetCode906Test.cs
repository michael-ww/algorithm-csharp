namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode906Test
{
    [Fact]
    public void SuperpalindromesInRange_ValidInput_ReturnCount()
    {
        // Given

        // When
        LeetCode906 leetCode906 = new();
        int answer = leetCode906.SuperpalindromesInRange("4", "1000");

        // Then
        Assert.Equal(4, answer);
    }
}
