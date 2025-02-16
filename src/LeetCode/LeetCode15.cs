namespace Belly.Algorithm.LeetCode;

public class LeetCode15
{
    public IList<(int, int, int)> ThreeSum(int[] nums)
    {
        List<(int, int, int)> answer = [];
        if (nums == null || nums.Length <= 3)
        {
            return answer;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        answer.Add((nums[i], nums[j], nums[k]));
                    }
                    else if (nums[i] + nums[j] + nums[k] > 0)
                    {
                        break;
                    }
                }
            }
        }

        return answer;
    }
}
