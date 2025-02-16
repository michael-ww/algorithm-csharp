namespace Belly.Algorithm.LeetCode;

public class LeetCode39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        if (candidates == null || candidates.Length <= 0)
        {
            return answer;
        }
        this.DFS(candidates, 0, target, [], answer);
        return answer;
    }

    private void DFS(int[] candidates, int index, int target, IList<int> combine, IList<IList<int>> answer)
    {
        if (target == 0)
        {
            answer.Add(new List<int>(combine));
            return;
        }
        if (index >= candidates.Length)
        {
            return;
        }
        this.DFS(candidates, index + 1, target, combine, answer);
        if (target >= candidates.ElementAt(index))
        {
            combine.Add(candidates.ElementAt(index));
            this.DFS(candidates, index, target - candidates.ElementAt(index), combine, answer);
            combine.Remove(candidates.ElementAt(index));
        }
    }
}