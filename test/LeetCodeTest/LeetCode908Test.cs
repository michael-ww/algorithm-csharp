namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode908Test
{
    [Fact]
    public void SmallestRangeI_ValidInput_ReturnRange()
    {
        // Given
        int[] nums1 = { 0, 10 }, nums2 = { 1, 3, 6 };
        int k1 = 2, k2 = 3;

        // When
        int answer1 = new LeetCode908().SmallestRangeI(nums1, k1);
        int answer2 = new LeetCode908().SmallestRangeI(nums2, k2);

        // Then
        Assert.Equal(6, answer1);
        Assert.Equal(0, answer2);
    }
}
