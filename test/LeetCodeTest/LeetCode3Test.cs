namespace Algorithm.LeetCodeTest;

public class LeetCode3Test
{
    [Fact]
    public void LengthOfLongestSubstring_ValidInput_ReturnLongestLength()
    {
        // Given
        string s1 = "abcabcbb";
        string s2 = "bbbbb";
        string s3 = "pwwkew";

        // When
        LeetCode3 leetCode3 = new();
        int answer1 = leetCode3.LengthOfLongestSubstring(s1);
        int answer2 = leetCode3.LengthOfLongestSubstring(s2);
        int answer3 = leetCode3.LengthOfLongestSubstring(s3);

        // Then
        Assert.Equal(3, answer1);
        Assert.Equal(1, answer2);
        Assert.Equal(3, answer3);
    }
}
