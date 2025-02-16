namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode134Test
{
    [Fact]
    public void CanCompleteCircuit_ValidInput_ReturnStartPosition()
    {
        // Given
        int[] gas1 = [1, 2, 3, 4, 5], cost1 = [3, 4, 5, 1, 2];
        int[] gas2 = [2, 3, 4], cost2 = [3, 4, 3];

        // When
        LeetCode134 leetCode134 = new();
        int answer1 = leetCode134.CanCompleteCircuit(gas1, cost1);
        int answer2 = leetCode134.CanCompleteCircuit(gas2, cost2);

        // Then
        Assert.Equal(3, answer1);
        Assert.Equal(-1, answer2);
    }
}
