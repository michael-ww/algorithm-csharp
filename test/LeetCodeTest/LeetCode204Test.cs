namespace Algorithm.LeetCodeTest;

public class LeetCode204Test
{
    [Fact]
    public void CountPrimes_ValidInput_ReturnCount()
    {
        // Given

        // When
        LeetCode204 leetCode204 = new();
        int answer1 = leetCode204.CountPrimes(10);
        int answer2 = leetCode204.CountPrimes(20);
        int answer3 = leetCode204.CountPrimes(30);

        // Then
        Assert.Equal(4, answer1);
        Assert.Equal(8, answer2);
        Assert.Equal(10, answer3);
    }
}
