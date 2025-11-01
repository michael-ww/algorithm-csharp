namespace Belly.Algorithm.LeetCode;

public class LeetCode76
{
    public string MinWindow(string source, string target)
    {
        if (string.IsNullOrEmpty(source) || (!string.IsNullOrWhiteSpace(target) && source.Length < target.Length))
        {
            return string.Empty;
        }

        int[] cnts = new int[26];
        foreach (var item in target)
        {
            cnts[item]--;
        }
        int startIndex = 0, length = int.MaxValue;
        for (int leftIndex = 0, rightIndex = 0, debt = target.Length; rightIndex < source.Length; rightIndex++)
        {
            if (cnts[source[rightIndex]]++ < 0)
            {
                debt--;
            }
            if (debt == 0)
            {
                while (cnts[source[leftIndex]] > 0)
                {
                    cnts[source[leftIndex++]]--;
                }
                if (rightIndex - leftIndex + 1 < length)
                {
                    length = rightIndex - leftIndex + 1;
                    startIndex = leftIndex;
                }
            }
        }
        return length == int.MaxValue ? string.Empty : source.Substring(startIndex, length);
    }
}
