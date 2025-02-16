namespace Belly.Algorithm.LeetCode;

public class LeetCode213
{
    public int Rob(int[] nums)
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
            int previous1 = Math.Max(nums[0], nums[1]);
            for (int i = 2, current; i < nums.Length - 1; i++)
            {
                current = Math.Max(nums[i] + pprevious, previous1);
                pprevious = previous1;
                previous1 = current;
            }

            pprevious = nums[1];
            int previous2 = Math.Max(nums[1], nums[2]);
            for (int i = 3, current; i < nums.Length; i++)
            {
                current = Math.Max(nums[i] + pprevious, previous2);
                pprevious = previous2;
                previous2 = current;
            }

            return Math.Max(previous1, previous2);
        }
    }
}
