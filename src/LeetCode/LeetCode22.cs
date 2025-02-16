namespace Belly.Algorithm.LeetCode;

public class LeetCode22
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> answer = new();
        if (n <= 0)
        {
            return answer;
        }
        this.Backtrack(answer, n, n, new StringBuilder());
        return answer;
    }

    private void Backtrack(List<string> answer, int left, int right, StringBuilder sb)
    {
        if (left == 0 && right == 0)
        {
            answer.Add(sb.ToString());
            return;
        }

        if (left == right)
        {
            this.Backtrack(answer, left - 1, right, sb.Append('('));
            sb.Remove(sb.Length - 1, 1);
        }
        else if (left < right)
        {
            if (left > 0)
            {
                this.Backtrack(answer, left - 1, right, sb.Append('('));
                sb.Remove(sb.Length - 1, 1);
            }
            this.Backtrack(answer, left, right - 1, sb.Append(')'));
            sb.Remove(sb.Length - 1, 1);
        }
    }
}