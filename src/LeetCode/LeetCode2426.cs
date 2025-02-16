namespace Belly.Algorithm.LeetCode;

public class LeetCode2426
{
    public long NumberOfPairs(int[] nums1, int[] nums2, int diff)
    {
        if (nums1 == null || nums2 == null || nums1.Length <= 0 || nums2.Length <= 0)
        {
            return 0;
        }

        int[] nums = new int[nums1.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums1[i] - nums2[i];
        }

        return this.MergeSort(nums, 0, nums.Length - 1, diff);
    }

    private int MergeSort(int[] nums, int startIndex, int endIndex, int diff)
    {
        if (startIndex >= endIndex)
        {
            return 0;
        }

        int answer = 0;
        int middleIndex = startIndex + (endIndex - startIndex) >> 1;
        answer += this.MergeSort(nums, startIndex, middleIndex, diff);
        answer += this.MergeSort(nums, middleIndex + 1, endIndex, diff);

        for (int leftIndex = middleIndex, rightIndex = endIndex; rightIndex > middleIndex; rightIndex--)
        {
            while (leftIndex >= startIndex && nums[leftIndex] > nums[rightIndex] + diff)
            {
                leftIndex--;
            }
            if (leftIndex >= startIndex && nums[leftIndex] <= nums[rightIndex] + diff)
            {
                answer += leftIndex - startIndex + 1;
            }
        }

        int[] help = new int[endIndex - startIndex + 1];
        int li = startIndex, ri = middleIndex + 1, hi = 0;
        while (li <= middleIndex && ri <= endIndex)
        {
            help[hi++] = nums[li] <= nums[ri] ? nums[li++] : nums[ri++];
        }
        while (li <= middleIndex)
        {
            help[hi++] = nums[li++];
        }
        while (ri <= endIndex)
        {
            help[hi++] = nums[ri++];
        }
        for (int i = 0; i < help.Length; i++)
        {
            nums[startIndex + i] = help[i];
        }

        return answer;
    }
}
