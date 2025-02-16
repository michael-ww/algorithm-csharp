namespace Algorithm.LeetCodeTest;

public class LeetCode169Test
{
    [Fact]
    public void MajorityElement_ValidInput_ReturnElment()
    {
        // Given
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

        // When
        int answer1 = new LeetCode169().MajorityElement1(nums);
        int answer2 = new LeetCode169().MajorityElement2(nums);

        // Then
        Assert.Equal(2, answer1);
        Assert.Equal(2, answer2);
    }
}