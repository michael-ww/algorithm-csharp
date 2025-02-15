namespace Algorithm.LeetCode;

public class LeetCode239
{
    public int[] MaxSlidingWindow1(int[] nums, int k)
    {
        if (nums == null || nums.Length <= 0 || k <= 0)
        {
            return null;
        }

        if (k > nums.Length)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                this.HeapInsert(nums, i);
            }
            return [nums[0]];
        }

        int[] answer = new int[nums.Length - k + 1];
        int[] help = new int[k];
        int leftIndex = 0, rightIndex = k - 1;
        while (rightIndex < nums.Length)
        {
            Array.Copy(nums, leftIndex, help, 0, k);
            for (int i = 0; i < k; i++)
            {
                this.HeapInsert(help, i);
            }
            answer[leftIndex] = help[0];
            leftIndex++;
            rightIndex++;
        }

        return answer;
    }

    private void HeapInsert(int[] nums, int index)
    {
        while (nums[index] > nums[(index - 1) / 2])
        {
            Utility.Swap(nums, index, (index - 1) / 2);
            index = (index - 1) / 2;
        }
    }

    private void Heapify(int[] nums, int index, int heapSize)
    {
        int left = index * 2 + 1;
        while (left < heapSize)
        {
            int largest = left + 1 < heapSize && nums[left + 1] > nums[left] ? left + 1 : left;
            largest = nums[largest] > nums[index] ? largest : index;
            if (largest == index)
            {
                break;
            }
            index = largest;
            left = index * 2 + 1;
        }
    }

    public int[] MaxSlidingWindow2(int[] nums, int k)
    {
        if (nums == null || nums.Length <= 0 || k <= 0)
        {
            return null;
        }

        PriorityQueue<int, int> pq = new(Comparer<int>.Create((int x, int y) => { return y - x; }));
        for (int i = 0; i < Math.Min(k, nums.Length); i++)
        {
            pq.Enqueue(i, nums[i]);
        }

        int[] answer = new int[nums.Length - k + 1];
        answer[0] = nums[pq.Peek()];
        for (int i = k; i < nums.Length; i++)
        {
            pq.Enqueue(i, nums[i]);
            while (pq.Peek() <= i - k)
            {
                pq.Dequeue();
            }
            answer[i - k + 1] = nums[pq.Peek()];
        }
        return answer;
    }

    public int[] MaxSlidingWindow3(int[] nums, int k)
    {
        LinkedList<int> deque = [];
        for (int i = 0; i < k - 1; i++)
        {
            while (deque.Count > 0 && nums[deque.Last()] <= nums[i])
            {
                deque.RemoveLast();
            }
            deque.AddLast(i);
        }
        int[] answer = new int[nums.Length - k + 1];
        for (int left = 0, right = k - 1; right < nums.Length; left++, right++)
        {
            while (deque.Count > 0 && nums[deque.Last()] <= nums[right])
            {
                deque.RemoveLast();
            }
            deque.AddLast(right);
            answer[left] = nums[deque.First()];
            if (deque.First() == left)
            {
                deque.RemoveFirst();
            }
        }
        return answer;
    }
}
