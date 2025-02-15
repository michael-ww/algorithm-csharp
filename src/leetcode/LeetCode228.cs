namespace Algorithm.LeetCode;

public class LeetCode228
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> answer = new();
        if (nums == null || nums.Length <= 0)
        {
            return answer;
        }
        for (int low = 0, high = 0; low < nums.Length && high < nums.Length; low = high)
        {
            high = low;
            while (high < nums.Length && nums[high] - nums[low] == high - low)
            {
                high++;
            }
            answer.Add(low + 1 == high ? nums[low].ToString() : $"{nums[low]}->{nums[high - 1]}");
        }

        return answer;
    }
}
