namespace Algorithm.LeetCodeTest;

public class LeetCode31Test
{
    [Fact]
    public void NextPermutation_ValidInput_PerformExpectation()
    {
        //Arrange
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int[] nums2 = { 1, 2, 3, 5, 4 };
        int[] nums3 = { 1, 2, 4, 5, 3 };
        int[] nums4 = { 5, 4, 3, 2, 1 };

        //Act
        LeetCode31 leetCode31 = new();
        leetCode31.NextPermutation(nums1);
        leetCode31.NextPermutation(nums2);
        leetCode31.NextPermutation(nums3);
        leetCode31.NextPermutation(nums4);

        //Assert
        Assert.Equal(new int[] { 1, 2, 3, 5, 4 }, nums1);
        Assert.Equal(new int[] { 1, 2, 4, 3, 5 }, nums2);
        Assert.Equal(new int[] { 1, 2, 5, 3, 4 }, nums3);
        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, nums4);
    }
}
