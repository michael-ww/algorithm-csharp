namespace Algorithm.LeetCode;

public class LeetCode85
{
    public int MaximalRectangle(int[,] matrix)
    {
        int answer = 0;
        int[] height = new int[matrix.GetLength(1)];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                height[column] = matrix[row, column] == 0 ? 0 : height[column] + matrix[row, column];
            }
            answer = Math.Max(answer, this.LargestRectangleArea(height));
        }

        return answer;
    }

    private int LargestRectangleArea(int[] height)
    {
        int answer = 0;
        Stack<int> stack = [];
        for (int i = 0; i < height.Length; i++)
        {
            if (stack.Count > 0 && height[stack.Peek()] >= height[i])
            {
                int index = stack.Pop();
                int left = stack.Count > 0 ? stack.Peek() : -1;
                answer = Math.Max(answer, height[index] * (i - left - 1));
            }
            stack.Push(i);
        }

        while (stack.Count > 0)
        {
            int index = stack.Pop();
            int left = stack.Count > 0 ? stack.Peek() : -1;
            answer = Math.Max(answer, height[index] * (height.Length - left - 1));
        }

        return answer;
    }
}