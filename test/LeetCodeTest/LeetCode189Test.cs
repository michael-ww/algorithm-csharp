namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode189Test
{
    [Fact]
    public void Rotate_ValidInput_PerformExpectation()
    {
        // Given
        LeetCode189 leetCode189 = new();
        int[] nums1 = [1, 2, 3, 4, 5, 6, 7], nums2 = [-1, -100, 3, 99];

        // When
        leetCode189.Rotate(nums1, 3);
        leetCode189.Rotate(nums2, 2);

        // Then
        Assert.Equal([5, 6, 7, 1, 2, 3, 4], nums1);
        Assert.Equal([3, 99, -1, -100], nums2);

    }
}