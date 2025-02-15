namespace Algorithm.LeetCode;

public class LeetCode350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        if (nums1 == null || nums2 == null || nums1.Length <= 0 || nums2.Length <= 0)
        {
            return null;
        }

        List<int> answer = new();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int nums1Index = 0, nums2Index = 0;
        while (nums1Index < nums1.Length && nums2Index < nums2.Length)
        {
            if (nums1[nums1Index] < nums2[nums2Index])
            {
                nums1Index++;
            }
            else if (nums1[nums1Index] > nums2[nums2Index])
            {
                nums2Index++;
            }
            else
            {
                answer.Add(nums1[nums1Index]);
                nums1Index++;
                nums2Index++;
            }
        }

        return answer.ToArray();
    }
}
