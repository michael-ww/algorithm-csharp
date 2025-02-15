namespace Algorithm.LeetCode;

public class LeetCode1590
{
    public int MinSubarray(int[] nums, int p)
    {
        if (nums == null || nums.Length <= 0)
        {
            return -1;
        }

        int remainder = 0;
        foreach (var item in nums)
        {
            remainder = (remainder + item) % p;
        }

        if (remainder == 0)
        {
            return 0;
        }

        Dictionary<int, int> ris = new() { { 0, -1 } };
        int answer = int.MaxValue;
        for (int i = 0, current = 0, find; i < nums.Length; i++)
        {
            current = (current + nums[i]) % p;
            find = (current + p - remainder) % p;
            if (ris.ContainsKey(find))
            {
                answer = Math.Min(answer, i - ris[find]);
            }
            if (ris.TryGetValue(current, out int _))
            {
                ris[current] = i;
            }
            else
            {
                ris.Add(current, i);
            }
        }

        return answer == nums.Length ? -1 : answer;
    }
}