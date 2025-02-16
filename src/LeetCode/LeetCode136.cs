namespace Belly.Algorithm.LeetCode;

public class LeetCode136
{
    public int SingleNumber(int[] nums)
    {
        int eor = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            eor ^= nums[i];
        }

        return eor;
    }
}