namespace Belly.Algorithm.LeetCode;

public class LeetCode14
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length <= 0)
        {
            return string.Empty;
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        string answer = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            int j = 0;
            for (; j < Math.Min(answer.Length, strs[i].Length); j++)
            {
                if (answer[j] != strs[i][j])
                {
                    break;
                }
            }
            answer = answer.Substring(0, j);
            if (string.IsNullOrWhiteSpace(answer))
            {
                break;
            }
        }
        return answer;
    }
}
