namespace Algorithm.LeetCodeTests
{
    public class LeetCode1438Test
    {
        [Fact]
        public void LongestSubarray_ValidInput_ReturnLength()
        {
            // Arrange

            // Act
            LeetCode1438 leetCode1438 = new();
            int result1 = leetCode1438.LongestSubarray1([8, 2, 4, 7], 4);
            int result2 = leetCode1438.LongestSubarray1([10, 1, 2, 4, 7, 2], 5);
            int result3 = leetCode1438.LongestSubarray1([4, 2, 2, 2, 4, 4, 2, 2], 0);

            // Assert
            Assert.Equal(2, result1);
            Assert.Equal(4, result2);
            Assert.Equal(3, result3);
        }
    }
}