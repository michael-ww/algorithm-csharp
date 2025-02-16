namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode209Test
{
    [Fact]
    public void MinSubArrayLen_ValidInput_ReturnLength()
    {
        // Given
        int[] nums1 = [2, 3, 1, 2, 4, 3], nums2 = [1, 4, 4], nums3 = [1, 1, 1, 1, 1, 1, 1, 1];

        // When
        LeetCode209 leetCode209 = new();
        int answer1 = leetCode209.MinSubArrayLen(7, nums1);
        int answer2 = leetCode209.MinSubArrayLen(4, nums2);
        int answer3 = leetCode209.MinSubArrayLen(11, nums3);

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(1, answer2);
        Assert.Equal(0, answer3);
    }
}
