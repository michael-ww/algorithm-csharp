namespace Algorithm.LeetCode;

public class LeetCode962
{
    public int MaxWidthRamp(int[] nums)
    {
        Stack<int> stack = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (stack.Count <= 0 || (stack.Count > 0 && nums[stack.Peek()] > nums[i]))
            {
                stack.Push(i);
            }
        }

        int width = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && nums[stack.Peek()] <= nums[i])
            {
                width = Math.Max(width, i - stack.Pop());
            }
        }

        return width;
    }
}
