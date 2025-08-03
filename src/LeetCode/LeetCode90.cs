namespace Belly.Algorithm.LeetCode;

public class LeetCode90
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        List<IList<int>> answer = [];
        if (nums == null || nums.Length <= 0)
        {
            return answer;
        }
        Array.Sort(nums);
        this.DFS(nums, 0, [], answer);
        return answer;
    }

    private void DFS(int[] nums, int index, List<int> path, IList<IList<int>> answer)
    {
        answer.Add([.. path]);
        for (int i = index; i < nums.Length; i++)
        {
            if (i > index && nums[i] == nums[i - 1])
            {
                continue;
            }
            path.Add(nums[i]);
            this.DFS(nums, i + 1, path, answer);
            path.RemoveAt(path.Count - 1);
        }
    }
}
