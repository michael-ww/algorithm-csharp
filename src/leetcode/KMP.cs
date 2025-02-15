namespace Algorithm.LeetCode;

//Time Complexity : O(N) string matching
public class KMP
{
    public int GetIndexOf(string text, string pattern)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern) || text.Length <= 0 || pattern.Length <= 0 || text.Length < pattern.Length)
        {
            return -1;
        }
        int[] next = this.GetNextArray(pattern);
        if (next == null)
        {
            return -1;
        }

        int textIndex = 0, patternIndex = 0;
        while (textIndex < text.Length && patternIndex < pattern.Length)
        {
            if (text[textIndex] == pattern[patternIndex])
            {
                textIndex++;
                patternIndex++;
            }
            else
            {
                if (next[patternIndex] == -1)
                {
                    textIndex++;
                }
                else
                {
                    patternIndex = next[patternIndex];
                }
            }
        }

        return patternIndex == pattern.Length ? textIndex - patternIndex : -1;
    }

    private int[] GetNextArray(string pattern)
    {
        char[] charactors = pattern.ToCharArray();
        if (charactors.Length == 1)
        {
            return [-1];
        }
        else
        {
            int[] answer = new int[charactors.Length];
            answer[0] = -1;
            answer[1] = 0;
            int index = 2, cn = 0;
            while (index < charactors.Length)
            {
                if (charactors[index - 1] == charactors[cn])
                {
                    answer[index++] = ++cn;
                }
                else if (cn > 0)
                {
                    cn = answer[cn];
                }
                else
                {
                    answer[index] = 0;
                }
            }
            return answer;
        }
    }
}
