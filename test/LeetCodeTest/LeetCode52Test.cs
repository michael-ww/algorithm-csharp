namespace Algorithm.LeetCodeTest;

public class LeetCode52Test
{
    [Fact]
    public void TotalNQueens_ValidInput_ReturnWays()
    {
        // Given

        // When
        LeetCode52 leetCode52 = new();
        int answer1 = leetCode52.TotalNQueens(5);
        int answer2 = leetCode52.TotalNQueens(1);
        int answer3 = leetCode52.TotalNQueens(9);

        // Then
        Assert.Equal(10, answer1);
        Assert.Equal(1, answer2);
        Assert.Equal(352, answer3);
    }
}
