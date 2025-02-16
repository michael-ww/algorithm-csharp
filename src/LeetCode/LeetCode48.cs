namespace Belly.Algorithm.LeetCode;

public class LeetCode48
{
    // Time Complexity: O(n*n)
    // Space Complexity: O(n*n)
    public void Rotate1(int[,] matrix)
    {
        if (matrix == null || matrix.Length <= 0)
        {
            return;
        }

        int[,] help = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                help[j, matrix.GetLength(0) - i - 1] = matrix[i, j];
            }
        }

        for (int i = 0; i < help.GetLength(0); i++)
        {
            for (int j = 0; j < help.GetLength(1); j++)
            {
                matrix[i, j] = help[i, j];
            }
        }
    }

    public void Rotate2(int[,] matrix)
    {
        if (matrix == null || matrix.Length <= 0)
        {
            return;
        }
        int n = matrix.GetLength(0);
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = i; j < (n - 1) / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[n - j - 1, i];
                matrix[n - j - 1, i] = matrix[n - i - 1, n - j - 1];
                matrix[n - i - 1, n - j - 1] = matrix[j, n - i - 1];
                matrix[j, n - i - 1] = temp;
            }
        }
    }
}
