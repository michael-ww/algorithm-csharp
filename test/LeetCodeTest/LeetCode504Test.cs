namespace Algorithm.LeetCodeTest;

public class LeetCode504Test
{
    [Fact]
    public void ConvertToBase7_ValidInput_ReturnNumber()
    {
        // Given

        // When
        LeetCode504 leetCode504 = new();
        string answer1 = leetCode504.ConvertToBase7(100);
        string answer2 = leetCode504.ConvertToBase7(-7);

        // Then
        Assert.Equal("202", answer1);
        Assert.Equal("-10", answer2);
    }
}
