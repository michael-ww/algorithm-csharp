namespace Belly.Algorithm.LeetCodeTest;

public class ChineseChessTest
{
    [Fact]
    public void CalculateWays1_ValidInput_ReturnWays()
    {
        // Given

        // When
        ChineseChess chineseChess = new();
        int answer = chineseChess.CalculateWays1(6, 6, 10);

        // Then
        Assert.Equal(861098, answer);
    }

    [Fact]
    public void CalculateWays2_ValidInput_ReturnWays()
    {
        // Given

        // When
        ChineseChess chineseChess = new();
        int answer = chineseChess.CalculateWays2(6, 6, 10);

        // Then
        Assert.Equal(861098, answer);
    }

    [Fact]
    public void CalculateWays3_ValidInput_ReturnWays()
    {
        // Given

        // When
        ChineseChess chineseChess = new();
        int answer = chineseChess.CalculateWays3(6, 6, 10);

        // Then
        Assert.Equal(861098, answer);
    }
}
