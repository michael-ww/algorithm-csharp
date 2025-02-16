namespace Belly.Algorithm.LeetCode;

public class LeetCode84
{
    public int LargestRectangleArea(int[] heights)
    {
        int answer = 0;
        Stack<int> stack = [];
        for (int i = 0; i < heights.Length; i++)
        {
            if (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                int index = stack.Pop();
                int left = stack.Count <= 0 ? -1 : stack.Peek();
                answer = Math.Max(answer, heights[index] * (i - left - 1));
            }
            else
            {
                stack.Push(i);
            }
        }

        while (stack.Count > 0)
        {
            int index = stack.Pop();
            int left = stack.Count <= 0 ? -1 : stack.Peek();
            answer = Math.Max(answer, heights[index] * (heights.Length - left - 1));
        }

        return answer;
    }
}
