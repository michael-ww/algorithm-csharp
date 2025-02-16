namespace Algorithm.LeetCodeTest;

public class LeetCode239Test
{
    [Fact]
    public void MaxSlidingWindow1_ValidInput_ReturnArray()
    {
        // Given
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int windowSize = 3;

        // When
        int[] answer = new LeetCode239().MaxSlidingWindow1(nums, windowSize);

        // Then
        Assert.Equal(6, answer.Length);
        Assert.Equal(3, answer[0]);
        Assert.Equal(3, answer[1]);
        Assert.Equal(5, answer[2]);
        Assert.Equal(5, answer[3]);
        Assert.Equal(6, answer[4]);
        Assert.Equal(7, answer[5]);
    }

    [Fact]
    public void MaxSlidingWindow2_ValidInput_ReturnArray()
    {
        // Given
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int windowSize = 3;

        // When
        int[] answer = new LeetCode239().MaxSlidingWindow2(nums, windowSize);

        // Then
        Assert.Equal(6, answer.Length);
        Assert.Equal(3, answer[0]);
        Assert.Equal(3, answer[1]);
        Assert.Equal(5, answer[2]);
        Assert.Equal(5, answer[3]);
        Assert.Equal(6, answer[4]);
        Assert.Equal(7, answer[5]);
    }
}