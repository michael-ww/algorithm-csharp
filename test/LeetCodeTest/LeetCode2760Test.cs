namespace Algorithm.LeetCodeTest;

public class LeetCode2760Test
{
    [Fact]
    public void LongestAlternatingSubarray_ValidInput_ReturnMaximumLength()
    {
        // Given
        int[] nums1 = [3, 2, 5, 4], nums2 = [1, 2], nums3 = [2, 3, 4, 5];
        int threshold1 = 5, threshold2 = 2, threshold3 = 4;

        // When
        LeetCode2760 leetCode2760 = new();
        int answer1 = leetCode2760.LongestAlternatingSubarray1(nums1, threshold1);
        int answer2 = leetCode2760.LongestAlternatingSubarray1(nums2, threshold2);
        int answer3 = leetCode2760.LongestAlternatingSubarray1(nums3, threshold3);

        // Then
        Assert.Equal(3, answer1);
        Assert.Equal(1, answer2);
        Assert.Equal(3, answer3);
    }
}
