namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode137Test
{
    [Fact]
    public void SingleNumber_ValidInput_ReturnSingleNumber()
    {
        // Given
        int[] nums = { 0, 1, 0, 1, 0, 1, 99 };

        // When
        int answer1 = new LeetCode137().SingleNumber1(nums);
        int answer2 = new LeetCode137().SingleNumber2(nums);

        // Then
        Assert.Equal(99, answer1);
        Assert.Equal(99, answer2);
    }
}
