namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode67Test
{
    [Fact]
    public void AddBinary1_ValidInput_ReturnString()
    {
        // Given
        string a1 = "11", b1 = "11";
        string a2 = "1010", b2 = "1011";

        // When
        string answer1 = new LeetCode67().AddBinary1(a1, b1);
        string answer2 = new LeetCode67().AddBinary1(a2, b2);

        // Then
        Assert.Equal("110", answer1);
        Assert.Equal("10101", answer2);
    }

    [Fact]
    public void AddBinary2_ValidInput_ReturnString()
    {
        // Given
        string a1 = "11", b1 = "11";
        string a2 = "1010", b2 = "1011";

        // When
        string answer1 = new LeetCode67().AddBinary2(a1, b1);
        string answer2 = new LeetCode67().AddBinary2(a2, b2);

        // Then
        Assert.Equal("110", answer1);
        Assert.Equal("10101", answer2);
    }

    [Fact]
    public void AddBinary3_ValidInput_ReturnString()
    {
        // Given
        string a1 = "11", b1 = "11";
        string a2 = "1010", b2 = "1011";

        // When
        string answer1 = new LeetCode67().AddBinary3(a1, b1);
        string answer2 = new LeetCode67().AddBinary3(a2, b2);

        // Then
        Assert.Equal("110", answer1);
        Assert.Equal("10101", answer2);
    }
}
