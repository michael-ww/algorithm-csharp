namespace Belly.Algorithm.LeetCode;

public class LeetCode40
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        if (candidates == null || candidates.Length <= 0)
        {
            return answer;
        }
        Array.Sort(candidates);
        this.DFS(candidates, 0, target, [], answer);
        return answer;
    }

    private void DFS(int[] candidates, int index, int target, IList<int> combine, IList<IList<int>> answer)
    {
        if (target == 0)
        {
            answer.Add([.. combine]);
            return;
        }
        if (index >= candidates.Length)
        {
            return;
        }
        for (int i = index; i < candidates.Length; i++)
        {
            if (target < candidates[i])
            {
                break;
            }
            if (i > index && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            combine.Add(candidates[i]);
            this.DFS(candidates, i + 1, target - candidates[i], combine, answer);
            combine.Remove(candidates[i]);
        }

    }
}
