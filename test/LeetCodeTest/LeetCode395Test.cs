namespace Algorithm.LeetCodeTest;

public class LeetCode395Test
{
    [Fact]
    public void LongestSubstring_ValidInput_ReturnLength()
    {
        // Given
        string s1 = "aaabb", s2 = "ababbc";
        int k1 = 3, k2 = 2;

        // When
        LeetCode395 leetCode395 = new();
        int answer1 = leetCode395.LongestSubstring(s1, k1);
        int answer2 = leetCode395.LongestSubstring(s2, k2);

        // Then
        Assert.Equal(3, answer1);
        Assert.Equal(5, answer2);
    }
}
