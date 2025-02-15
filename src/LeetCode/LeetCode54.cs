namespace Algorithm.LeetCode;

public class LeetCode54
{
    public IList<int> SpiralOrder(int[,] matrix)
    {
        IList<int> answer = [];
        int top = 0, bottom = matrix.GetLength(0) - 1, left = 0, right = matrix.GetLength(1) - 1;
        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
            {
                answer.Add(matrix[top, i]);
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                answer.Add(matrix[i, right]);
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    answer.Add(matrix[bottom, i]);
                }
            }
            bottom--;

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    answer.Add(matrix[i, left]);
                }
            }
            left++;
        }

        return answer;
    }
}
