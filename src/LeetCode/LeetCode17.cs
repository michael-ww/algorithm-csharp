namespace Belly.Algorithm.LeetCode;

public class LeetCode17
{
    public IList<string> LetterCombinations(string digits)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(digits);
        List<string> answer = new();
        Dictionary<char, string> phoneMap = new() { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };
        this.Backtrack(answer, phoneMap, digits, 0, new StringBuilder());
        return answer;
    }

    private void Backtrack(List<string> answer, Dictionary<char, string> phoneMap, string digits, int index, StringBuilder sb)
    {
        if (index >= digits.Length)
        {
            answer.Add(sb.ToString());
        }
        else
        {
            string letters = phoneMap[digits[index]];
            for (int i = 0; i < letters.Length; i++)
            {
                sb.Append(letters.ElementAt(i));
                this.Backtrack(answer, phoneMap, digits, index + 1, sb);
                sb.Remove(index, 1);
            }
        }
    }
}
