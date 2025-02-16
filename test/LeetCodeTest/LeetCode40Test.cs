namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode40Test
{
    [Fact]
    public void CombinationSum2_ValidInput_ReturnCombinations()
    {
        // Given

        // When
        LeetCode40 leetCode40 = new();
        IList<IList<int>> answer1 = leetCode40.CombinationSum2([10, 1, 2, 7, 6, 1, 5], 8);
        IList<IList<int>> answer2 = leetCode40.CombinationSum2([2, 5, 2, 1, 2], 5);

        // Then
        Assert.Equal(4, answer1.Count);
        Assert.Contains([1, 1, 6], answer1);
        Assert.Contains([1, 2, 5], answer1);
        Assert.Contains([1, 7], answer1);
        Assert.Contains([2, 6], answer1);
        Assert.Equal(2, answer2.Count);
        Assert.Contains([1, 2, 2], answer2);
        Assert.Contains([5], answer2);
    }
}
