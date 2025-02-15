namespace Algorithm.LeetCode;

public class LeetCode198
{
    public int Rob1(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }
        (int robbing, int notRobbing) = this.Process(nums, nums.Length - 1);
        return Math.Max(robbing, notRobbing);
    }

    private (int, int) Process(int[] nums, int index)
    {
        if (index == 0)
        {
            return (nums[0], 0);
        }
        (int robbing, int notRobbing) = this.Process(nums, index - 1);
        return (nums[index] + notRobbing, Math.Max(robbing, notRobbing));
    }

    public int Rob2(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }
        else if (nums.Length == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        else
        {
            int pprevious = nums[0];
            int previous = Math.Max(nums[0], nums[1]);
            for (int i = 2, current; i < nums.Length; i++)
            {
                current = Math.Max(nums[i] + pprevious, previous);
                pprevious = previous;
                previous = current;
            }

            return previous;
        }
    }
}
