namespace Belly.Algorithm.LeetCode;

public class LeetCode46
{
    // Time Complexity: O(n*n!)
    // Space Complexity: O(n)
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> answer = [];
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
            for (int i = index; i < nums.Length; i++)
            {
                Utility.Swap(nums, i, index);
                this.Backtrack(nums, index + 1, answer);
                Utility.Swap(nums, i, index);
            }
        }
    }
}
