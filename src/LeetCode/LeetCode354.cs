namespace Belly.Algorithm.LeetCode;

public class LeetCode354
{
    public int MaxEnvelopes(int[][] envelopes)
    {
        if (envelopes.Length == 0) return 0;

        // Sort envelopes by width in ascending order, and by height in descending order for equal widths
        Array.Sort(envelopes, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));

        // Extract the heights
        int[] heights = new int[envelopes.Length];
        for (int i = 0; i < envelopes.Length; i++)
        {
            heights[i] = envelopes[i][1];
        }

        // Find the length of the longest increasing subsequence in heights
        return LengthOfLIS(heights);
    }

    private int LengthOfLIS(int[] nums)
    {
        List<int> list = [];
        foreach (var num in nums)
        {
            int index = list.BinarySearch(num);
            if (index < 0) index = ~index; // Get the insertion point
            if (index < list.Count)
            {
                list[index] = num; // Replace existing value
            }
            else
            {
                list.Add(num); // Append new value
            }
        }
        return list.Count;
    }
}