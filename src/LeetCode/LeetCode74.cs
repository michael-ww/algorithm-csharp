namespace Belly.Algorithm.LeetCode;

public class LeetCode74
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        ArgumentNullException.ThrowIfNull(matrix);
        int m = matrix.Length, n = matrix[0].Length;
        int low = 0, high = m * n - 1;
        while (low <= high)
        {
            int middle = low + (high - low) / 2;
            if (matrix[middle / n][middle % n] == target)
            {
                return true;
            }
            else if (matrix[middle / n][middle % n] > target)
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }
        }

        return false;
    }
}
