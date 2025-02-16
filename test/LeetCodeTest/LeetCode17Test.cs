namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode17Test
{
    [Fact]
    public void LetterCombinations()
    {
        // Given

        // When
        LeetCode17 leetCode17 = new();
        IList<string> answer1 = leetCode17.LetterCombinations("23");
        IList<string> answer2 = leetCode17.LetterCombinations("3697");

        // Then
    }
}
