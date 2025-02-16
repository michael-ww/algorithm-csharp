namespace Belly.Algorithm.LeetCode;

public class LeetCode1504
{
    public int NumSubmat(int[,] mat)
    {
        int answer = 0;
        int[] height = new int[mat.GetLength(1)];
        for (int row = 0; row < mat.GetLength(0); row++)
        {
            for (int column = 0; column < mat.GetLength(1); column++)
            {
                height[column] = mat[row, column] == 0 ? 0 : mat[row, column] + height[column];
            }
            answer += this.CountSubmat(height);
        }
        return answer;
    }

    private int CountSubmat(int[] height)
    {
        int answer = 0;
        Stack<int> stack = [];
        for (int index = 0, left, length, bottom; index < height.Length; index++)
        {
            while (stack.Count > 0 && height[stack.Peek()] >= height[index])
            {
                int top = stack.Pop();
                if (height[top] > height[index])
                {
                    left = stack.Count <= 0 ? -1 : stack.Peek();
                    length = index - left - 1;
                    bottom = Math.Max(left == -1 ? 0 : height[left], height[index]);
                    answer += (height[top] - bottom) * length * (length + 1) / 2;
                }
            }
            stack.Push(index);
        }
        while (stack.Count > 0)
        {
            int top = stack.Pop();
            int left = stack.Count <= 0 ? -1 : stack.Peek();
            int length = height.Length - left - 1;
            int down = left == -1 ? 0 : height[left];
            answer += (height[top] - down) * length * (length + 1) / 2;
        }
        return answer;
    }
}