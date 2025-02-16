namespace Algorithm.LeetCodeTest;

public class LeetCode88Test
{
    [Fact]
    public void Merge1_ValidInput_Succeed()
    {
        // Given
        int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
        int m = 3, n = 3;

        // When
        new LeetCode88().Merge1(nums1, m, nums2, n);

        // Then
        Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Fact]
    public void Merge2_ValidInput_Succeed()
    {
        // Given
        int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
        int m = 3, n = 3;

        // When
        new LeetCode88().Merge2(nums1, m, nums2, n);

        // Then
        Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Fact]
    public void Merge3_ValidInput_Succeed()
    {
        // Given
        int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
        int m = 3, n = 3;

        // When
        new LeetCode88().Merge3(nums1, m, nums2, n);

        // Then
        Assert.Equal(new int[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }
}
