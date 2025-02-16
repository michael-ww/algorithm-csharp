namespace Algorithm.LeetCodeTest;

public class LeetCode345Test
{
    [Fact]
    public void ReverseVowels_ValidInput_ReturnReversedString()
    {
        // Given
        string s1 = "hello";
        string s2 = "leetcode";

        // When
        LeetCode345 leetCode345 = new();
        string answer1 = leetCode345.ReverseVowels(s1);
        string answer2 = leetCode345.ReverseVowels(s2);

        // Then
        Assert.Equal("holle", answer1);
        Assert.Equal("leotcede", answer2);
    }
}
