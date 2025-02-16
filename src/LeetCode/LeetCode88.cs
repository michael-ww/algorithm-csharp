namespace Belly.Algorithm.LeetCode;

public class LeetCode88
{
    public void Merge1(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums1 == null || m <= 0 || nums2 == null || n <= 0)
        {
            return;
        }
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }


    public void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums1 == null || m <= 0 || nums2 == null || n <= 0)
        {
            return;
        }

        int[] sorted = new int[m + n];
        int nums1Index = 0, nums2Index = 0, index = 0;
        while (nums1Index < m && nums2Index < n)
        {
            sorted[index++] = nums1[nums1Index] <= nums2[nums2Index] ? nums1[nums1Index++] : nums2[nums2Index++];
        }
        while (nums1Index < m)
        {
            sorted[index++] = nums1[nums1Index++];
        }
        while (nums2Index < n)
        {
            sorted[index++] = nums2[nums2Index++];
        }

        for (int i = 0; i < sorted.Length; i++)
        {
            nums1[i] = sorted[i];
        }
    }

    public void Merge3(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums1 == null || m <= 0 || nums2 == null || n <= 0)
        {
            return;
        }

        int nums1Index = m - 1, nums2Index = n - 1, index = m + n - 1;
        while (nums1Index >= 0 && nums2Index >= 0)
        {
            nums1[index--] = nums1[nums1Index] >= nums2[nums2Index] ? nums1[nums1Index--] : nums2[nums2Index--];
        }
        while (nums1Index >= 0)
        {
            nums1[index--] = nums1[nums1Index--];
        }
        while (nums2Index >= 0)
        {
            nums1[index--] = nums2[nums2Index--];
        }
    }
}
