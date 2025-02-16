namespace Algorithm.LeetCodeTest;

public class LeetCode162Test
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, 2)]
    [InlineData(new int[] { 1, 2, 1, 3, 5, 6, 4 }, 5)]
    public void FindPeakElement_ValidInput_ReturnMaximum(int[] nums, int expected)
    {
        // Arrange
        LeetCode162 leetCode162 = new();

        // Act
        int result = leetCode162.FindPeakElement(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
