namespace Algorithm.LeetCodeTest;

public class LeetCode136Test
{
    [Fact]
    public void SingleNumber_ValidInput_ReturnSingleNumber()
    {
        // Given
        int[] nums = { 4, 1, 2, 1, 2 };

        // When
        int answer = new LeetCode136().SingleNumber(nums);

        // Then
        Assert.Equal(4, answer);
    }
}
