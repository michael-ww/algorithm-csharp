namespace Algorithm.LeetCodeTest;

public class LeetCode64Test
{
    [Fact]
    public void MinPathSum_ValidInput_ReturnMinPathSum()
    {
        // Given

        // When
        LeetCode64 leetCode64 = new();
        int answer11 = leetCode64.MinPathSum1(new int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } });
        int answer12 = leetCode64.MinPathSum1(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
        int answer21 = leetCode64.MinPathSum2(new int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } });
        int answer22 = leetCode64.MinPathSum2(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
        int answer31 = leetCode64.MinPathSum3(new int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } });
        int answer32 = leetCode64.MinPathSum3(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
        int answer41 = leetCode64.MinPathSum4(new int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } });
        int answer42 = leetCode64.MinPathSum4(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });

        // Then
        Assert.Equal(7, answer11);
        Assert.Equal(12, answer12);
        Assert.Equal(7, answer21);
        Assert.Equal(12, answer22);
        Assert.Equal(7, answer31);
        Assert.Equal(12, answer32);
        Assert.Equal(7, answer41);
        Assert.Equal(12, answer42);
    }
}
