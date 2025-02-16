namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode44Test
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "*", true)]
    [InlineData("cb", "?a", false)]
    [InlineData("adceb", "*a*b", true)]
    [InlineData("acdcb", "a*c?b", false)]
    public void IsMatch_ValidInput_ReturnExpected(string s, string p, bool expected)
    {
        // Arrange
        LeetCode44 leetCode44 = new();

        // Act
        bool result1 = leetCode44.IsMatch1(s, p);
        bool result2 = leetCode44.IsMatch2(s, p);
        bool result3 = leetCode44.IsMatch3(s, p);

        // Assert
        Assert.Equal(expected, result1);
        Assert.Equal(expected, result2);
        Assert.Equal(expected, result3);
    }
}
