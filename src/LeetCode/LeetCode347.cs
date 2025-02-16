namespace Belly.Algorithm.LeetCode;

public class LeetCode347
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        if (nums == null || nums.Length <= 0 || k <= 0)
        {
            return null;
        }

        Dictionary<int, int> dictionary = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.TryGetValue(nums[i], out int value))
            {
                dictionary[nums[i]] = value + 1;
            }
            else
            {
                dictionary[nums[i]] = 1;
            }
        }

        PriorityQueue<int, int> heap = new(Comparer<int>.Create((int x, int y) => y - x));
        foreach (var item in dictionary)
        {
            heap.Enqueue(item.Value, item.Key);
        }
        int[] topK = new int[k];
        for (int i = 0; i < k && heap.Count > 0; i++)
        {
            topK[i] = heap.Dequeue();
        }
        return topK;
    }
}
