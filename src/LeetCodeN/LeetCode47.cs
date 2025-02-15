namespace Algorithm.LeetCode;

public class LeetCode47
{
    // Time Complexity: O(n!*n)
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        this.Backtrack(nums, 0, answer);
        return answer;
    }

    private void Backtrack(int[] nums, int index, IList<IList<int>> answer)
    {
        if (index >= nums.Length)
        {
            answer.Add([.. nums]);
        }
        else
        {
            HashSet<int> hs = [];
            for (int i = index; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                {
                    continue;
                }
                hs.Add(nums[i]);
                Utility.Swap(nums, i, index);
                this.Backtrack(nums, index + 1, answer);
                Utility.Swap(nums, i, index);

            }
        }
    }
}
