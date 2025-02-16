namespace Algorithm.LeetCodeTest;

public class LeetCode287Test
{
    [Fact]
    public void FindDuplicate_ValidInput_ReturnNumber()
    {
        // Given
        int[] nums1 = [1, 3, 4, 2, 2], nums2 = [3, 1, 3, 4, 2];

        // When
        LeetCode287 leetCode287 = new();
        int answer1 = leetCode287.FindDuplicate(nums1);
        int answer2 = leetCode287.FindDuplicate(nums2);

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(3, answer2);
    }
}
