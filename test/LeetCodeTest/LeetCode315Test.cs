namespace Algorithm.LeetCodeTest;

public class LeetCode315Test
{
    [Fact]
    public void CountSmaller_ValidInput_ReturnList()
    {
        // Given
        int[] nums1 = { 5, 2, 6, 1 };
        int[] nums2 = { -1, -1 };
        int[] nums3 = { 1, 6, 2, 8, 3, 7, 4, 9, 5 };

        // When
        int[] answer1 = new LeetCode315().CountSmaller(nums1);
        int[] answer2 = new LeetCode315().CountSmaller(nums2);
        int[] answer3 = new LeetCode315().CountSmaller(nums3);

        // Then
        Assert.Equal(2, answer1[0]);
        Assert.Equal(1, answer1[1]);
        Assert.Equal(1, answer1[2]);
        Assert.Equal(0, answer1[3]);
        Assert.Equal(0, answer2[0]);
        Assert.Equal(0, answer2[1]);
        Assert.Equal(0, answer3[0]);
        Assert.Equal(4, answer3[1]);
        Assert.Equal(0, answer3[2]);
        Assert.Equal(4, answer3[3]);
        Assert.Equal(0, answer3[4]);
        Assert.Equal(2, answer3[5]);
        Assert.Equal(0, answer3[6]);
        Assert.Equal(1, answer3[7]);
        Assert.Equal(0, answer3[8]);
    }
}
