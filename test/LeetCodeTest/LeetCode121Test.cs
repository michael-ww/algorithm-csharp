namespace Algorithm.LeetCodeTest;

public class LeetCode121Test
{
    [Fact]
    public void MaxProfit1_ValidInput_ReturnMaxProfit()
    {
        // Given
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        int[] prices2 = { 7, 6, 4, 3, 1 };

        // When
        int answer1 = new LeetCode121().MaxProfit1(prices1);
        int answer2 = new LeetCode121().MaxProfit1(prices2);

        // Then
        Assert.Equal(5, answer1);
        Assert.Equal(0, answer2);
    }

    [Fact]
    public void MaxProfit2_ValidInput_ReturnMaxProfit()
    {
        // Given
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        int[] prices2 = { 7, 6, 4, 3, 1 };

        // When
        int answer1 = new LeetCode121().MaxProfit2(prices1);
        int answer2 = new LeetCode121().MaxProfit2(prices2);

        // Then
        Assert.Equal(5, answer1);
        Assert.Equal(0, answer2);
    }
}
