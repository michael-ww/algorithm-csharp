namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode47Test
{
    [Fact]
    public void PermuteUnique_ValidInput_ReturnPermutation()
    {
        // Given
        int[] nums = [1, 1, 2];

        // When
        IList<IList<int>> answer = new LeetCode47().PermuteUnique(nums);

        // Then
        Assert.Equal(3, answer.Count);
        Assert.Contains([1, 1, 2], answer);
        Assert.Contains([1, 2, 1], answer);
        Assert.Contains([2, 1, 1], answer);
    }
}
