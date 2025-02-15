namespace Algorithm.LeetCode.Test
{
    public class LeetCode74Test
    {
        [Fact]
        public void SearchMatrix_ValidInput_ReturnBoolean()
        {
            // Given
            int[][] matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]];

            // When
            LeetCode74 leetCode74 = new();
            bool answer1 = leetCode74.SearchMatrix(matrix, 3);
            bool answer2 = leetCode74.SearchMatrix(matrix, 13);

            // Then
            Assert.True(answer1);
            Assert.False(answer2);
        }
    }
}