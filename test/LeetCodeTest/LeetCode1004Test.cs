namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode1004Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
    [InlineData(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
    public void LongestOnes_ValidInput_ReturnLongestOneCount(int[] nums, int k, int expected)
    {
        LeetCode1004 leetCode1004 = new();

        // Act
        int actual = leetCode1004.LongestOnes(nums, k);

        // Assert
        Assert.Equal(expected, actual);
    }
}