namespace Belly.Algorithm
{
    public class LeetCode912Test
    {
        [Fact]
        public void SortArray_ValidInput_ReturnSortedArray()
        {
            // Arrange
            LeetCode912 leetCode912 = new();
            int[] input = [4, 5, 4, 3, 2, 1, 2];
            int[] expected = [1, 2, 2, 3, 4, 4, 5];

            // Act
            int[] result = leetCode912.SortArray(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}