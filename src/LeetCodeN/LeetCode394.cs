namespace Algorithm.LeetCode;

public class LeetCode394
{
    public string DecodeString(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return string.Empty;
        }

        int where = 0;
        return this.DecodeString(s.ToCharArray(), 0, ref where);
    }

    private string DecodeString(char[] charactors, int index, ref int where)
    {
        StringBuilder answer = new();
        int repeatCount = 0;
        while (index < charactors.Length && charactors[index] != ']')
        {
            if (char.IsUpper(charactors[index]) || char.IsLower(charactors[index]))
            {
                answer.Append(charactors[index++]);
            }
            else if (char.IsDigit(charactors[index]))
            {
                repeatCount = repeatCount * 10 + charactors[index++] - '0';
            }
            else if (charactors[index] == '[')
            {
                string substring = this.DecodeString(charactors, index + 1, ref where);
                for (int i = 0; i < repeatCount; i++)
                {
                    answer.Append(substring);
                }
                index = where + 1;
                repeatCount = 0;
            }
        }
        where = index;
        return answer.ToString();
    }
}
