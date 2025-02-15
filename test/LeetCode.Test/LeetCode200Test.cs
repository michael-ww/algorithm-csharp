namespace Algorithm.LeetCode.Test
{
    public class LeetCode200Test
    {
        [Fact]
        public void CountIslands_ValidInput_ReturnCount()
        {
            // Given
            char[][] grid1 = { new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '1', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '0', '0', '0' } };
            char[][] grid2 = { new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1', '1' } };

            // When
            LeetCode200 leetCode200 = new();
            int islandCount1 = leetCode200.CountIslands(grid1);
            int islandCount2 = leetCode200.CountIslands(grid2);

            // Then
            Assert.Equal(1, islandCount1);
            Assert.Equal(3, islandCount2);
        }
    }
}