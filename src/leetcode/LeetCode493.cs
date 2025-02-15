namespace Algorithm.LeetCode;

public class LeetCode493
{
    public int ReversePairs(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length < 2)
        {
            return 0;
        }
        return this.Partition(nums, 0, nums.Length - 1);
    }

    private int Partition(int[] nums, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return 0;
        }
        int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
        int leftCount = this.Partition(nums, leftIndex, middleIndex);
        int rightCount = this.Partition(nums, middleIndex + 1, rightIndex);
        int mergeCount = this.Merge(nums, leftIndex, middleIndex, rightIndex);
        return leftCount + rightCount + mergeCount;
    }

    private int Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex)
    {
        int answer = 0;
        for (int i = leftIndex, j = middleIndex + 1; i <= middleIndex; i++)
        {
            while (j <= rightIndex && nums[i] > 2 * nums[j])
            {
                j++;
            }
            answer += j - middleIndex - 1;
        }

        int[] help = new int[rightIndex - leftIndex + 1];
        int index = 0, left = leftIndex, right = middleIndex + 1;
        while (left <= middleIndex && right <= rightIndex)
        {
            help[index++] = nums[left] <= nums[right] ? nums[left++] : nums[right++];
        }
        while (left <= middleIndex)
        {
            help[index++] = nums[left++];
        }
        while (right <= rightIndex)
        {
            help[index++] = nums[right++];
        }
        for (int i = 0; i < help.Length; i++)
        {
            nums[leftIndex + i] = help[i];
        }
        return answer;
    }
}
