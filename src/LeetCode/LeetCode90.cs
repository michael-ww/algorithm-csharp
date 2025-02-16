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
        if (index >= nums.Length)
        {
            answer.Add([.. path]);
        }
        else
        {
            path.Add(nums[index]);
            this.DFS(nums, index + 1, path, answer);
            path.RemoveAt(path.Count - 1);
            int next = index + 1;
            while (next < nums.Length && nums[next] == nums[index])
            {
                next++;
            }
            this.DFS(nums, next, path, answer);
        }
    }
}
