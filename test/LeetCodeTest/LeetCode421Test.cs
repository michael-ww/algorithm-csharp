namespace Algorithm.LeetCodeTest;

public class LeetCode421Test
{
    [Fact]
    public void FindMaximumXOR1_ValidInput_ReturnMaximumXOR()
    {
        // Given
        int[] nums1 = [14, 70, 53, 83, 49, 91, 36, 80, 92, 51, 66, 70], nums2 = [3, 10, 5, 25, 2, 8];

        // When
        LeetCode421 leetCode421 = new();
        int answer11 = leetCode421.FindMaximumXOR1(nums1);
        int answer12 = leetCode421.FindMaximumXOR1(nums2);

        // Then
        Assert.Equal(127, answer11);
        Assert.Equal(28, answer12);
    }
}
