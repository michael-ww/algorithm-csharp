namespace Algorithm.LeetCode;

public class LeetCode421
{
    public int FindMaximumXOR1(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfLessThan(nums.Length, 0);

        int answer = 0;
        foreach (var item1 in nums)
        {
            foreach (var item2 in nums)
            {
                answer = Math.Max(answer, item1 ^ item2);
            }
        }

        return answer;
    }
}
