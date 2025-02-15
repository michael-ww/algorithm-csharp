namespace Algorithm.LeetCode;

public class LeetCode303
{
    private readonly int[] sums;

    public LeetCode303(int[] nums)
    {
        this.sums = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            sums[i + 1] = sums[i] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        if (left < 0 && right >= this.sums.Length)
        {
            return 0;
        }

        return this.sums[right + 1] - this.sums[left];
    }
}
