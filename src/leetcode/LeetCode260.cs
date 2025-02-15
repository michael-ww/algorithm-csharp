namespace Algorithm.LeetCode;

public class LeetCode260
{
    public int[] SingleNumber(int[] nums)
    {
        if (nums == null || nums.Length < 2)
        {
            return null;
        }

        int eor1 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            eor1 ^= nums[i];
        }

        int mostRightOne = eor1 & (~eor1 + 1);
        int eor2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] & mostRightOne) == 0)
            {
                eor2 ^= nums[i];
            }
        }

        return new int[] { eor1 ^ eor2, eor2 };
    }
}