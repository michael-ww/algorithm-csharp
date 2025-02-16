namespace Algorithm.LeetCodeTest;

public class LeetCode63Test
{
    [Fact]
    public void UniquePathsWithObstacles_ValidInput_ReturnPathCount()
    {
        // Given

        // When
        LeetCode63 leetCode63 = new();
        int answer1 = leetCode63.UniquePathsWithObstacles([[0, 0, 0], [0, 1, 0], [0, 0, 0]]);
        int answer2 = leetCode63.UniquePathsWithObstacles([[0, 1], [0, 0]]);

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(1, answer2);
    }
}
