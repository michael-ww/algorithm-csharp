namespace Algorithm.LeetCodeTest;

public class LeetCode78Test
{
    [Fact]
    public void Subsets_ValidInput_ReturnSubsets()
    {
        // Given
        int[] nums = { 1, 2, 3 };

        // When
        List<List<int>> answer1 = new LeetCode78().Subsets1(nums);
        List<List<int>> answer2 = new LeetCode78().Subsets2(nums);


        // Then
        Assert.Equal(8, answer1.Count);
        Assert.Contains([], answer1);
        Assert.Contains([1], answer1);
        Assert.Contains([2], answer1);
        Assert.Contains([1, 2], answer1);
        Assert.Contains([3], answer1);
        Assert.Contains([1, 3], answer1);
        Assert.Contains([2, 3], answer1);
        Assert.Contains([1, 2, 3], answer1);

        Assert.Equal(8, answer2.Count);
        Assert.Contains([], answer2);
        Assert.Contains([1], answer2);
        Assert.Contains([2], answer2);
        Assert.Contains([1, 2], answer2);
        Assert.Contains([3], answer2);
        Assert.Contains([1, 3], answer2);
        Assert.Contains([2, 3], answer2);
        Assert.Contains([1, 2, 3], answer2);
    }
}
