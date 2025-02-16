namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode992Test
{
    [Fact]
    public void SubarraysWithKDistinct_ValidInput_ReturnCount()
    {
        // Given
        int[] nums1 = [1, 2, 1, 2, 3], nums2 = [1, 2, 1, 3, 4];
        int k1 = 2, k2 = 3;

        // When
        LeetCode992 leetCode992 = new();
        int answer1 = leetCode992.SubarraysWithKDistinct(nums1, k1);
        int answer2 = leetCode992.SubarraysWithKDistinct(nums2, k2);

        // Then
        Assert.Equal(7, answer1);
        Assert.Equal(3, answer2);
    }
}