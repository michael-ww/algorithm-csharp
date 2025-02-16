namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode130Test
{
    [Fact]
    public void Solve_ValidInput_Expect()
    {
        // Given
        char[,] board1 = { { 'X', 'X', 'X', 'X' }, { 'X', 'O', 'O', 'X' }, { 'X', 'X', 'O', 'X' }, { 'X', 'O', 'X', 'X' } };

        // When
        new LeetCode130().Solve(board1);

        // Then
        for (int i = 0; i < board1.GetLength(0); i++)
        {
            for (int j = 0; j < board1.GetLength(1); j++)
            {
                Assert.Equal('X', board1[i, j]);
            }
        }
    }
}
