namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode720Test
{
    [Fact]
    public void LongestWord_ValidInput_ReturnLongestWord()
    {
        // Given
        string[] words1 = ["w", "wo", "wor", "worl", "world"];
        string[] words2 = ["a", "banana", "app", "appl", "ap", "apply", "apple"];

        // When
        LeetCode720 leetCode720 = new();
        string answer1 = leetCode720.LongestWord(words1);
        string answer2 = leetCode720.LongestWord(words2);

        // Then
        Assert.Equal("world", answer1);
        Assert.Equal("apple", answer2);
    }
}
