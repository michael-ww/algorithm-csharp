namespace Algorithm.LeetCode;

public class LeetCode212
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        ISet<string> answer = new HashSet<string>();
        if (board == null || words == null || words.Length <= 0)
        {
            return answer.ToList();
        }

        TrieNode trie = this.BuildTrie(words);
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                this.DFS(board, i, j, trie, answer);
            }
        }

        return answer.ToList();
    }

    private void DFS(char[][] board, int row, int column, TrieNode current, ISet<string> answer)
    {
        if (row < 0 || row >= board.Length || column < 0 || column >= board[row].Length || board[row][column] == '*' || !current.Nexts.ContainsKey(board[row][column]))
        {
            return;
        }
        TrieNode next = current.Nexts[board[row][column]];
        if (!string.IsNullOrEmpty(next.Value))
        {
            answer.Add(next.Value);
        }
        char letter = board[row][column];
        board[row][column] = '*';
        this.DFS(board, row + 1, column, next, answer);
        this.DFS(board, row - 1, column, next, answer);
        this.DFS(board, row, column + 1, next, answer);
        this.DFS(board, row, column - 1, next, answer);
        board[row][column] = letter;
    }

    private TrieNode BuildTrie(string[] words)
    {
        TrieNode root = new();
        foreach (var word in words)
        {
            TrieNode current = root;
            foreach (var letter in word)
            {
                if (!current.Nexts.ContainsKey(letter))
                {
                    current.Nexts.Add(letter, new());
                }
                current = current.Nexts[letter];
            }
            current.Value = word;
        }
        return root;
    }
}
