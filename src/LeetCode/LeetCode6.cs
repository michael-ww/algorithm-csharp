namespace Belly.Algorithm.LeetCode;

public class LeetCode6
{
    public string Convert(string s, int numRows)
    {
        if (numRows < 2)
        {
            return s;
        }
        List<StringBuilder> rows = new();
        for (int k = 0; k < numRows; k++)
        {
            rows.Append(new StringBuilder());
        }
        int i = 0, flag = -1;
        foreach (char c in s)
        {
            rows.ElementAt(i).Append(c);
            if (i == 0 || i == numRows - 1) flag = -flag;
            i += flag;
        }
        StringBuilder res = new StringBuilder();
        foreach (StringBuilder row in rows)
        {
            res.Append(row);
        }
        return res.ToString();
    }
}
