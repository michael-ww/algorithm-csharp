namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode410Test
{
    [Fact]
    public void SplitArray_ValidInput_ReturnMinMax()
    {
        // Given
        int[] nums1 = [7, 2, 5, 10, 8], nums2 = [1, 2, 3, 4, 5], nums3 = [1, 4, 4];
        int k1 = 2, k2 = 2, k3 = 3;

        // When
        LeetCode410 leetCode410 = new();
        int answer1 = leetCode410.SplitArray(nums1, k1);
        int answer2 = leetCode410.SplitArray(nums2, k2);
        int answer3 = leetCode410.SplitArray(nums3, k3);

        // Then
        Assert.Equal(18, answer1);
        Assert.Equal(9, answer2);
        Assert.Equal(4, answer3);
    }
}
