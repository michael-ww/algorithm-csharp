namespace Algorithm.LeetCode;

public class LeetCode79
{
    public bool Exist(char[,] board, string word)
    {
        if (board == null || board.Length <= 0)
        {
            return false;
        }
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (this.Backtrack(board, i, j, word, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool Backtrack(char[,] board, int row, int column, string word, int index)
    {
        if (index >= word.Length)
        {
            return true;
        }
        if (row < 0 || row >= board.GetLength(0) || column < 0 || column >= board.GetLength(1) || board[row, column] == '*' || board[row, column] != word[index])
        {
            return false;
        }

        char letter = board[row, column];
        board[row, column] = '*';
        bool left = this.Backtrack(board, row, column - 1, word, index + 1);
        bool right = this.Backtrack(board, row, column + 1, word, index + 1);
        bool up = this.Backtrack(board, row - 1, column, word, index + 1);
        bool down = this.Backtrack(board, row + 1, column, word, index + 1);
        board[row, column] = letter;
        return left || right || up || down;
    }
}
