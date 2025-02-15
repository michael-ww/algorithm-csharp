namespace Algorithm.LeetCode;

public class LeetCode2760
{
    public int LongestAlternatingSubarray1(int[] nums, int threshold)
    {
        int answer = 0;
        for (int left = 0; left < nums.Length; left++)
        {
            for (int right = left; right < nums.Length; right++)
            {
                if (this.IsSatisfied(nums, left, right, threshold))
                {
                    answer = Math.Max(answer, right - left + 1);
                }
            }
        }

        return answer;
    }

    private bool IsSatisfied(int[] nums, int left, int right, int threshold)
    {
        if (nums[left] % 2 != 0)
        {
            return false;
        }
        for (int i = left; i <= right; i++)
        {
            if (nums[i] > threshold || (i < right && nums[i] % 2 == nums[i + 1] % 2))
            {
                return false;
            }
        }
        return true;
    }

    public int LongestAlternatingSubarray2(int[] nums, int threshold)
    {
        int answer = 0, dp = 0;
        for (int l = nums.Length - 1; l >= 0; l--)
        {
            if (nums[l] > threshold)
            {
                dp = 0;
            }
            else if (l == nums.Length - 1 || nums[l] % 2 != nums[l + 1] % 2)
            {
                dp++;
            }
            else
            {
                dp = 1;
            }
            if (nums[l] % 2 == 0)
            {
                answer = Math.Max(answer, dp);
            }
        }
        return answer;
    }
}
