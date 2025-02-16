namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode922Test
{
    [Fact]
    public void SortArrayByParityII_ValidInput_ReturnArray()
    {
        // Given
        int[] nums1 = [4, 2, 5, 7], nums2 = [2, 3];

        // When
        LeetCode922 leetCode922 = new();
        int[] answer1 = leetCode922.SortArrayByParityII(nums1);
        int[] answer2 = leetCode922.SortArrayByParityII(nums2);

        // Then

    }
}
