namespace Algorithm.LeetCode;

public class LeetCode30
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> answer = [];
        if (string.IsNullOrWhiteSpace(s) || words == null || words.Length <= 0)
        {
            return answer;
        }
        for (int i = 0; i < words.First().Length && i + words.First().Length * words.Length <= s.Length; i++)
        {
            Dictionary<string, int> differ = [];
            for (int j = 0; j < words.Length; j++)
            {
                string substring = s.Substring(i + j * words.First().Length, words.First().Length);
                if (!differ.ContainsKey(substring))
                {
                    differ.Add(substring, 0);
                }
                differ[substring]++;
            }

            foreach (var item in words)
            {
                if (!differ.ContainsKey(item))
                {
                    differ.Add(item, 0);
                }
                differ[item]--;
                if (differ[item] < 0)
                {
                    differ.Remove(item);
                }
            }

            for (int start = i; start < s.Length - words.Length * words.First().Length + 1; start += words.First().Length)
            {
                if (start != i)
                {
                    string word = s.Substring(start + (words.Length - 1) * words.First().Length, words.First().Length);
                    if (!differ.ContainsKey(word))
                    {
                        differ.Add(word, 0);
                    }
                    differ[word]++;
                    if (differ[word] == 0)
                    {
                        differ.Remove(word);
                    }
                    word = s.Substring(start - words.First().Length, words.First().Length);
                    if (!differ.ContainsKey(word))
                    {
                        differ.Add(word, 0);
                    }
                    differ[word]--;
                    if (differ[word] == 0)
                    {
                        differ.Remove(word);
                    }
                }
                if (differ.Count == 0)
                {
                    answer.Add(start);
                }

            }
        }

        return answer;
    }
}
