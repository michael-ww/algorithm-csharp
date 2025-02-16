namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode171Test
{
    [Fact]
    public void TitleToNumber_ValidInput_ReturnNumber()
    {
        // Given
        string s1 = "FXSHRXW";
        string s2 = "ZY";

        // When
        LeetCode171 leetCode171 = new();
        int answer1 = leetCode171.TitleToNumber(s1);
        int answer2 = leetCode171.TitleToNumber(s2);

        // Then
        Assert.Equal(2147483647, answer1);
        Assert.Equal(701, answer2);
    }
}
