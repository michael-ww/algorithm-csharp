namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode746Test
{
    [Fact]
    public void MinCostClimbingStairs_ValidInput_ReturnMinCost()
    {
        // Given
        int[] cost1 = [10, 15, 20];
        int[] cost2 = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];

        // When
        LeetCode746 leetCode746 = new();
        int answer1 = leetCode746.MinCostClimbingStairs(cost1);
        int answer2 = leetCode746.MinCostClimbingStairs(cost2);

        // Then
        Assert.Equal(15, answer1);
        Assert.Equal(6, answer2);
    }
}
