namespace Algorithm.LeetCodeTest;

public class LeetCode5Test
{
    [Fact]
    public void LongestPalindrome_ValidInput_ReturnPalindrome()
    {
        // Given
        string s1 = "babad", s2 = "cbbd";

        // When
        LeetCode5 leetCode5 = new();
        string answer11 = leetCode5.LongestPalindrome1(s1);
        string answer12 = leetCode5.LongestPalindrome1(s2);
        string answer21 = leetCode5.LongestPalindrome2(s1);
        string answer22 = leetCode5.LongestPalindrome2(s2);

        // Then
        Assert.Equal("bab", answer11);
        Assert.Equal("bb", answer12);
        Assert.Equal("bab", answer21);
        Assert.Equal("bb", answer22);
    }
}
