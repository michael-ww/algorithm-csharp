namespace Algorithm.LeetCodeTest;
public class LeetCode1124Test
{
    [Fact]
    public void LongestWPI_ValidInput_ReturnLongestWPI()
    {
        // Given
        int[] hours1 = [9, 9, 6, 0, 6, 6, 9], hours2 = [6, 6, 6];

        // When
        LeetCode1124 leetCode1124 = new();
        int answer1 = leetCode1124.LongestWPI(hours1);
        int answer2 = leetCode1124.LongestWPI(hours2);

        // Then
        Assert.Equal(3, answer1);
        Assert.Equal(0, answer2);
    }
}
