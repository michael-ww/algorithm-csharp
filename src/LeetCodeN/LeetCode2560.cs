namespace Algorithm.LeetCode;

public class LeetCode2560
{
    public int MinCapability(int[] nums, int k)
    {
        if (nums == null || nums.Length <= 0 || k < 0 || k > nums.Length)
        {
            return 0;
        }
        int minCapability = int.MaxValue, maxCapability = int.MinValue;
        foreach (var item in nums)
        {
            if (item < minCapability)
            {
                minCapability = item;
            }
            if (item > maxCapability)
            {
                maxCapability = item;
            }
        }
        int answer = 0;
        while (minCapability <= maxCapability)
        {
            int middleCapability = (minCapability + maxCapability) >> 1;
            if (this.IsSatisfy(nums, k, middleCapability, 0))
            {
                answer = middleCapability;
                maxCapability = middleCapability - 1;
            }
            else
            {
                minCapability = middleCapability + 1;
            }
        }

        return answer;
    }

    private bool IsSatisfy(int[] nums, int k, int capability, int index)
    {
        if (k == 0)
        {
            return true;
        }
        if (index >= nums.Length)
        {
            return false;
        }
        if (nums[index] > capability)
        {
            return this.IsSatisfy(nums, k, capability, index + 1);
        }
        else
        {
            return this.IsSatisfy(nums, k - 1, capability, index + 2);
        }
    }

}