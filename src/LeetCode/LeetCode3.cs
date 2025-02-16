namespace Belly.Algorithm.LeetCode;

public class LeetCode3
{
    public int LengthOfLongestSubstring(string s)
    {
        int answer = int.MinValue;
        int[] lastIndexes = new int[256];
        Array.Fill(lastIndexes, -1);
        for (int leftIndex = 0, rightIndex = 0; rightIndex < s.Length; rightIndex++)
        {
            leftIndex = Math.Max(leftIndex, lastIndexes[s[rightIndex]] + 1);
            answer = Math.Max(answer, rightIndex - leftIndex + 1);
            lastIndexes[s[rightIndex]] = rightIndex;
        }

        return answer;
    }
}
