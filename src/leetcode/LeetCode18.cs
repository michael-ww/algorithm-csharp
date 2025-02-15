namespace Algorithm.LeetCode;

public class LeetCode18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfLessThan(nums.Length, 4);
        Array.Sort(nums);
        List<IList<int>> answer = new List<IList<int>>();
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
                int k = j + 1, z = nums.Length - 1;
                while (k < z)
                {
                    if (k > j + 1 && nums[k] == nums[k - 1])
                    {
                        k++;
                        continue;
                    }
                    if (z < nums.Length - 1 && nums[z] == nums[z + 1])
                    {
                        z--;
                        continue;
                    }
                    int sum = nums[i] + nums[j] + nums[k] + nums[z];
                    if (sum > target)
                    {
                        z--;
                    }
                    else if (sum < target)
                    {
                        k++;
                    }
                    else
                    {
                        answer.Add(new List<int>() { nums[i], nums[j], nums[k], nums[z] });
                        k++;
                        z--;
                    }
                }
            }
        }
        return answer;
    }
}
