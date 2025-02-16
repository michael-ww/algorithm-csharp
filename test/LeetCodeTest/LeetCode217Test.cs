namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode217Test
{
    [Fact]
    public void ContainsDuplicate_ValidInput_ReturnBoolean()
    {
        // Given
        int[] nums1 = { 1, 2, 3, 1 };
        int[] nums2 = { 1, 2, 3, 4 };
        int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        // When
        LeetCode217 leetCode217 = new();
        bool answer11 = leetCode217.ContainsDuplicate1(nums1);
        bool answer12 = leetCode217.ContainsDuplicate1(nums2);
        bool answer13 = leetCode217.ContainsDuplicate1(nums3);
        bool answer21 = leetCode217.ContainsDuplicate2(nums1);
        bool answer22 = leetCode217.ContainsDuplicate2(nums2);
        bool answer23 = leetCode217.ContainsDuplicate2(nums3);

        // Then
        Assert.True(answer11);
        Assert.False(answer12);
        Assert.True(answer13);
        Assert.True(answer21);
        Assert.False(answer22);
        Assert.True(answer23);
    }
}