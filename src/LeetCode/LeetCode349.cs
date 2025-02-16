namespace Belly.Algorithm.LeetCode;

public class LeetCode349
{
    public int[] Intersection1(int[] nums1, int[] nums2)
    {
        if (nums1 == null || nums2 == null || nums1.Length <= 0 || nums2.Length <= 0)
        {
            return null;
        }

        List<int> answer = new();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (answer.Contains(nums1[i]))
            {
                continue;
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    answer.Add(nums1[i]);
                    break;
                }
            }
        }

        return answer.ToArray();
    }


    public int[] Intersection2(int[] nums1, int[] nums2)
    {
        if (nums1 == null || nums2 == null || nums1.Length <= 0 || nums2.Length <= 0)
        {
            return null;
        }

        return nums1.Intersect(nums2).ToArray();
    }
}
