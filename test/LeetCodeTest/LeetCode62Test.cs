namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode62Test
{
    [Fact]
    public void UniquePaths_ValidInput_ReturnWayCount()
    {
        // Given

        // When
        LeetCode62 leetCode62 = new();
        int answer1 = leetCode62.UniquePaths(3, 7);
        int answer2 = leetCode62.UniquePaths(3, 2);
        int answer3 = leetCode62.UniquePaths(7, 3);
        int answer4 = leetCode62.UniquePaths(3, 3);

        // Then
        Assert.Equal(28, answer1);
        Assert.Equal(3, answer2);
        Assert.Equal(28, answer3);
        Assert.Equal(6, answer4);
    }
}
