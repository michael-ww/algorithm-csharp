namespace Belly.Algorithm.LeetCode;

public class LeetCode719
{
    public int SmallestDistancePair(int[] nums, int k)
    {
        Array.Sort(nums);
        int answer = 0, left = 0, right = nums[^1] - nums[0];
        while (left <= right)
        {
            int middle = left + ((right - left) >> 1);
            int count = this.BinarySearch(nums, middle);
            if (count >= k)
            {
                answer = middle;
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return answer;

    }

    private int BinarySearch(int[] nums, int limit)
    {
        int answer = 0;
        for (int left = 0, right = 0; left < nums.Length; left++)
        {
            while (right < nums.Length - 1 && nums[right + 1] - nums[left] <= limit)
            {
                right++;
            }
            answer += right - left;
        }

        return answer;
    }
}
