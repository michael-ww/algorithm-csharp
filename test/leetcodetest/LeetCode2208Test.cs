namespace Algorithm.LeetCodeTests
{
    public class LeetCode2208Test
    {
        [Theory]
        [InlineData(new int[] { 5, 19, 8, 1 }, 3)]
        [InlineData(new int[] { 3, 8, 20 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        public void HalveArray_ValidInput_ReturnExpected(int[] nums, int expected)
        {
            // Arrange
            LeetCode2208 leetCode2208 = new();

            // Act
            int actual = leetCode2208.HalveArray(nums);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}