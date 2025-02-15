namespace Algorithm.LeetCode;

public class LeetCode1438
{
    public int LongestSubarray1(int[] nums, int limit)
    {
        int answer = 0;
        int[] maxQueue = new int[nums.Length];
        int[] minQueue = new int[nums.Length];
        int maxHead = 0, maxTail = 0, minHead = 0, minTail = 0;
        for (int left = 0, right = 0; left < nums.Length; left++)
        {
            while (right < nums.Length && this.IsSatisfied(nums, right, limit, maxQueue, maxHead, maxTail, minQueue, minHead, minTail))
            {
                while (maxHead < maxTail && nums[maxQueue[maxTail - 1]] < nums[right])
                {
                    maxTail--;
                }
                maxQueue[maxTail++] = right;
                while (minHead < minTail && nums[minQueue[minTail - 1]] > nums[right])
                {
                    minTail--;
                }
                minQueue[minTail++] = right;
                right++;
            }
            answer = Math.Max(answer, right - left);
            if (maxHead < maxTail && left == maxQueue[maxHead])
            {
                maxHead++;
            }
            if (minHead < minTail && left == minQueue[minHead])
            {
                minHead++;
            }
        }
        return answer;
    }

    private bool IsSatisfied(int[] nums, int index, int limit, int[] maxQueue, int maxHead, int maxTail, int[] minQueue, int minHead, int minTail)
    {
        int maximum = maxHead < maxTail ? Math.Max(nums[maxQueue[maxHead]], nums[index]) : nums[index];
        int minimum = minHead < minTail ? Math.Min(nums[minQueue[minHead]], nums[index]) : nums[index];
        return maximum - minimum <= limit;
    }

    public int LongestSubarray2(int[] nums, int limit)
    {
        int answer = 0;
        LinkedList<int> maxQueue = [];
        LinkedList<int> minQueue = [];
        for (int left = 0, right = 0; left < nums.Length; left++)
        {
            while (right < nums.Length && this.IsSatisfied(nums, right, limit, maxQueue, minQueue))
            {
                while (maxQueue.Count > 0 && nums[maxQueue.Last()] < nums[right])
                {
                    maxQueue.RemoveLast();
                }
                maxQueue.AddLast(right);
                while (minQueue.Count > 0 && nums[minQueue.Last()] > nums[right])
                {
                    minQueue.RemoveLast();
                }
                minQueue.AddLast(right);
                right++;
            }
            answer = Math.Max(answer, right - left);
            if (maxQueue.Count > 0 && maxQueue.First() == left)
            {
                maxQueue.RemoveFirst();
            }
            if (minQueue.Count > 0 && minQueue.First() == left)
            {
                minQueue.RemoveFirst();
            }
        }
        return answer;
    }

    private bool IsSatisfied(int[] nums, int index, int limit, LinkedList<int> maxQueue, LinkedList<int> minQueue)
    {
        int maximum = maxQueue.Count > 0 ? Math.Max(nums[maxQueue.First()], nums[index]) : nums[index];
        int minimum = minQueue.Count > 0 ? Math.Min(nums[minQueue.First()], nums[index]) : nums[index];
        return maximum - minimum <= limit;
    }

}