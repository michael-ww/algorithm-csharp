namespace Belly.Algorithm.LeetCode;

public class LeetCode907
{
    public int SumSubarrayMins(int[] arr)
    {
        long answer = 0;
        Stack<int> stack = [];
        for (int i = 0; i < arr.Length; i++)
        {
            if (stack.Count > 0 && arr[stack.Peek()] >= arr[i])
            {
                int index = stack.Pop();
                int left = stack.Count <= 0 ? -1 : stack.Peek();
                answer = (answer + (long)(index - left) * (i - index) * arr[index]) % 1000000007;
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
            answer = (answer + (long)(index - left) * (arr.Length - index) * arr[index]) % 1000000007;
        }

        return (int)answer;
    }
}
