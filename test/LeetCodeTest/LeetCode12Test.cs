namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode12Test
{
    [Fact]
    public void IntToRoman_ValidInput_ReturnRoman()
    {
        // Given

        // When
        LeetCode12 leetCode12 = new();
        string answer1 = leetCode12.IntToRoman(9);
        string answer2 = leetCode12.IntToRoman(58);
        string answer3 = leetCode12.IntToRoman(1994);

        // Then
        Assert.Equal("IX", answer1);
        Assert.Equal("LVIII", answer2);
        Assert.Equal("MCMXCIV", answer3);
    }
}
