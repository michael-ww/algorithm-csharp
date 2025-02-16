namespace Algorithm.LeetCodeTest;

public class LeetCode1590Test
{
    [Fact]
    public void MinSubarray_ValidInput_ReturnLength()
    {
        // Given
        int[] nums1 = [3, 1, 4, 2], nums2 = [6, 3, 5, 2], nums3 = [1, 2, 3], nums4 = [1000000000, 1000000000, 1000000000];

        // When
        LeetCode1590 leetCode1590 = new();
        int answer1 = leetCode1590.MinSubarray(nums1, 6);
        int answer2 = leetCode1590.MinSubarray(nums2, 9);
        int answer3 = leetCode1590.MinSubarray(nums3, 3);
        int answer4 = leetCode1590.MinSubarray(nums3, 7);
        int answer5 = leetCode1590.MinSubarray(nums4, 3);

        // Then
        Assert.Equal(1, answer1);
        Assert.Equal(2, answer2);
        Assert.Equal(0, answer3);
        Assert.Equal(-1, answer4);
        Assert.Equal(0, answer5);

    }
}
