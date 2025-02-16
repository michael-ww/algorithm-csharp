namespace Algorithm.LeetCodeTest;

public class LeetCode22Test
{
    [Fact]
    public void GenerateParenthesis_ValidInput_ReturnParenthesises()
    {
        // Given

        // When
        LeetCode22 leetCode22 = new();
        IList<string> answer1 = leetCode22.GenerateParenthesis(3);
        IList<string> answer2 = leetCode22.GenerateParenthesis(5);

        // Then
        Assert.Equal(5, answer1.Count);
        Assert.Equal(42, answer2.Count);
    }
}
