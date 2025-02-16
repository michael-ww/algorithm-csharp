namespace Belly.Algorithm.LeetCode;

public class LeetCode726
{
    public string CountOfAtoms(string formula)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(formula);
        int where = 0;
        SortedDictionary<string, int> preanswer = this.CountOfAtoms(formula.ToCharArray(), 0, ref where);
        StringBuilder answer = new();
        foreach (var item in preanswer)
        {
            answer.Append(item.Key);
            if (item.Value > 1)
            {
                answer.Append(item.Value);
            }
        }
        return answer.ToString();
    }

    private SortedDictionary<string, int> CountOfAtoms(char[] items, int index, ref int where)
    {
        SortedDictionary<string, int> answer = new();
        SortedDictionary<string, int> subanswer = null;
        StringBuilder name = new();
        int count = 0;
        while (index < items.Length && items[index] != ')')
        {
            if (char.IsUpper(items[index]) || items[index] == '(')
            {
                this.Fill(answer, subanswer, name.ToString(), count == 0 ? 1 : count);
                subanswer = null;
                name.Clear();
                count = 0;
                if (char.IsUpper(items[index]))
                {
                    name.Append(items[index++]);
                }
                else
                {
                    subanswer = this.CountOfAtoms(items, index + 1, ref where);
                    index = where + 1;
                }
            }
            else if (char.IsLower(items[index]))
            {
                name.Append(items[index++]);
            }
            else if (char.IsDigit(items[index]))
            {
                count = count * 10 + items[index++] - '0';
            }
        }
        this.Fill(answer, subanswer, name.ToString(), count == 0 ? 1 : count);
        where = index;
        return answer;
    }

    private void Fill(SortedDictionary<string, int> answer, SortedDictionary<string, int> subanswer, string name, int count)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            if (answer.TryGetValue(name, out int cnt))
            {
                answer[name] = count + cnt;
            }
            else
            {
                answer.Add(name, count);
            }
        }
        else if (subanswer != null)
        {
            foreach (var item in subanswer)
            {
                if (answer.TryGetValue(item.Key, out int cnt))
                {
                    answer[item.Key] = cnt + item.Value * count;
                }
                else
                {
                    answer.Add(item.Key, item.Value * count);
                }
            }
        }
    }
}
