namespace Belly.Algorithm.LeetCode;

public class LeetCode739
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] answer = new int[temperatures.Length];
        Stack<int> stack = new();
        for (int i = 0; i < temperatures.Length; i++)
        {
            if (stack.Count <= 0)
            {
                stack.Push(i);
            }
            else
            {
                if (temperatures[i] <= temperatures[stack.Peek()])
                {
                    stack.Push(i);
                }
                else
                {
                    int index = stack.Pop();
                    answer[index] = i - index;
                }
            }
        }

        return answer;
    }
}
