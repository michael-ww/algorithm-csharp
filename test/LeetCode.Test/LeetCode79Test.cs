namespace Algorithm.LeetCode.Test
{
    public class LeetCode79Test
    {
        [Fact]
        public void Exist_ValidInput_ReturBool()
        {
            // Given
            char[,] board = { { 'A', 'B', 'C', 'E' }, { 'S', 'F', 'C', 'S' }, { 'A', 'D', 'E', 'E' } };

            // When
            LeetCode79 leetCode79 = new();
            bool answer1 = leetCode79.Exist(board, "ABCCED");
            bool answer2 = leetCode79.Exist(board, "SEE");
            bool answer3 = leetCode79.Exist(board, "ABCB");

            // Then
            Assert.True(answer1);
            Assert.True(answer2);
            Assert.False(answer3);
        }
    }
}