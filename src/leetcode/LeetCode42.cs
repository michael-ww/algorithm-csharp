namespace Algorithm.LeetCode;

public class LeetCode42
{
    public int Trap1(int[] height)
    {
        if (height == null || height.Length < 2)
        {
            return 0;
        }

        int[] leftMaxinum = new int[height.Length];
        leftMaxinum[0] = height[0];
        for (int i = 1; i < height.Length; i++)
        {
            leftMaxinum[i] = Math.Max(leftMaxinum[i - 1], height[i]);
        }

        int[] rightMaxinum = new int[height.Length];
        rightMaxinum[^1] = height[^1];
        for (int i = height.Length - 2; i >= 0; i--)
        {
            rightMaxinum[i] = Math.Max(rightMaxinum[i + 1], height[i]);
        }

        int answer = 0;
        for (int i = 1; i < height.Length - 1; i++)
        {
            answer += Math.Max(0, Math.Min(leftMaxinum[i - 1], rightMaxinum[i + 1]) - height[i]);
        }

        return answer;
    }

    public int Trap2(int[] height)
    {
        if (height == null || height.Length < 2)
        {
            return 0;
        }

        int answer = 0, left = 1, right = height.Length - 2, lmax = height[0], rmax = height[^1];
        while (left <= right)
        {
            if (lmax <= rmax)
            {
                answer += Math.Max(0, lmax - height[left]);
                lmax = Math.Max(lmax, height[left++]);
            }
            else
            {
                answer += Math.Max(0, rmax - height[right]);
                rmax = Math.Max(rmax, height[right--]);
            }
        }

        return answer;
    }
}
