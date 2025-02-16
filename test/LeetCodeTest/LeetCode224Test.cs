namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode224Test
{
    [Fact]
    public void Caculate_ValidInput_ReturnResult()
    {
        // Given
        string s1 = "1+1", s2 = "2-1+2", s3 = "(1+(4+5+2)-3)+(6+8)";

        // When
        LeetCode224 leetCode224 = new();
        int answer1 = leetCode224.Calculate(s1);
        int answer2 = leetCode224.Calculate(s2);
        int answer3 = leetCode224.Calculate(s3);

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(3, answer2);
        Assert.Equal(23, answer3);
    }
}
