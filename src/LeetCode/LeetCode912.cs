namespace Algorithm.LeetCode;

public class LeetCode912
{
    public int[] SortArray(int[] nums)
    {
        this.QuickSort(nums);
        this.MergeSort(nums);
        this.HeapSort(nums);
        return nums;
    }

    public void QuickSort(int[] nums)
    {
        this.QuickSort(nums, 0, nums.Length - 1);
    }

    public void QuickSort(int[] nums, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            int pivotIndex = leftIndex + Random.Shared.Next(rightIndex - leftIndex);
            (int pivotLeftIndex, int pivotRightIndex) = Partition(nums, leftIndex, rightIndex, nums[pivotIndex]);
            QuickSort(nums, leftIndex, pivotLeftIndex - 1);
            QuickSort(nums, pivotRightIndex + 1, rightIndex);
        }
    }

    private (int, int) Partition(int[] nums, int leftIndex, int rightIndex, int pivot)
    {
        int cursor = leftIndex;
        while (cursor <= rightIndex)
        {
            if (nums[cursor] > pivot)
            {
                Utility.Swap(nums, cursor, rightIndex--);
            }
            else if (nums[cursor] < pivot)
            {
                Utility.Swap(nums, cursor++, leftIndex++);
            }
            else
            {
                cursor++;
            }
        }
        return (leftIndex, rightIndex);
    }

    public void MergeSort(int[] nums)
    {
        this.MergeSort(nums, 0, nums.Length - 1);
    }

    public void MergeSort(int[] nums, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) >> 1;
            MergeSort(nums, leftIndex, middleIndex);
            MergeSort(nums, middleIndex + 1, rightIndex);
            MergeSort(nums, leftIndex, middleIndex, rightIndex);
        }
    }

    private void MergeSort(int[] nums, int leftIndex, int middleIndex, int rightIndex)
    {
        int[] ordered = new int[rightIndex - leftIndex + 1];
        int orderedIndex = 0, leftCursor = leftIndex, rightCursor = middleIndex + 1;
        while (leftCursor <= middleIndex && rightCursor <= rightIndex)
        {
            ordered[orderedIndex++] = nums[leftCursor] <= nums[rightCursor] ? nums[leftCursor++] : nums[rightCursor++];
        }
        while (leftCursor <= middleIndex)
        {
            ordered[orderedIndex++] = nums[leftCursor++];
        }
        while (rightCursor <= rightIndex)
        {
            ordered[orderedIndex++] = nums[rightCursor++];
        }
        Array.Copy(ordered, 0, nums, leftIndex, ordered.Length);
    }

    public void HeapSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            this.HeapInsert(nums, i);
        }
        for (int i = nums.Length - 1; i > 0; i--)
        {
            Utility.Swap(nums, 0, i);
            this.Heapify(nums, 0, i);
        }
    }

    private void HeapInsert(int[] nums, int index)
    {
        while (nums[index] > nums[(index - 1) / 2])
        {
            Utility.Swap(nums, (index - 1) / 2, index);
            index = (index - 1) / 2;
        }
    }

    private void Heapify(int[] nums, int index, int heapSize)
    {
        int leftIndex = index * 2 + 1;
        while (leftIndex < heapSize)
        {
            int largestIndex = leftIndex + 1 < heapSize && nums[leftIndex + 1] > nums[leftIndex] ? leftIndex + 1 : leftIndex;
            largestIndex = nums[largestIndex] > nums[index] ? largestIndex : index;
            if (largestIndex == index)
            {
                break;
            }
            Utility.Swap(nums, index, largestIndex);
            index = largestIndex;
            leftIndex = index * 2 + 1;
        }
    }

    public void BubbleSort(int[] nums)
    {
        for (int i = nums.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    Utility.Swap(nums, j, j + 1);
                }
            }
        }
    }

    public void InsertionSort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = i - 1; j >= 0 && nums[j] > nums[j + 1]; j--)
            {
                Utility.Swap(nums, j, j + 1);
            }
        }
    }

    public void SelectionSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                minIndex = nums[j] < nums[minIndex] ? j : minIndex;
            }
            Utility.Swap(nums, i, minIndex);
        }
    }

    public void ShellSort(int[] nums)
    {

    }

    public void CountingSort(int[] nums)
    {

    }

    public void BucketSort(int[] nums)
    {

    }

    public void RadixSort(int[] nums)
    {
        this.RadixSort(nums, 0, nums.Length - 1, 10, this.GetMaxBits(nums));
    }

    private void RadixSort(int[] nums, int leftIndex, int rightIndex, int @base, int bits)
    {
        int[] counter = new int[@base];
        int[] bucket = new int[rightIndex - leftIndex + 1];
        for (int offset = 1; bits > 0; offset *= @base, bits--)
        {
            Array.Fill(counter, 0);
            foreach (int num in nums)
            {
                counter[num / offset % @base]++;
            }
            for (int i = 1; i < counter.Length; i++)
            {
                counter[i] += counter[i - 1];
            }
            for (int i = rightIndex; i >= leftIndex; i--)
            {
                bucket[--counter[nums[i] / offset % @base]] = nums[i];
            }
            Array.Copy(bucket, 0, nums, leftIndex, bucket.Length);
        }
    }

    private int GetMaxBits(int[] nums)
    {
        int answer = 0;
        int max = nums.Max();
        while (max != 0)
        {
            answer++;
            max /= 10;
        }
        return answer;
    }

    public void TimSort(int[] nums)
    {

    }

    public void CocktailSort(int[] nums)
    {

    }

    public void GnomeSort(int[] nums)
    {

    }

    public void CombSort(int[] nums)
    {

    }

    public void PigeonholeSort(int[] nums)
    {

    }

    public void CycleSort(int[] nums)
    {

    }

    public void StoogeSort(int[] nums)
    {

    }

    public void OddEvenSort(int[] nums)
    {

    }

    public void PancakeSort(int[] nums)
    {

    }

    public void BitonicSort(int[] nums)
    {

    }

    public void BogoSort(int[] nums)
    {

    }

    public void SleepSort(int[] nums)
    {

    }

    public void SlowSort(int[] nums)
    {

    }

    public void TreeSort(int[] nums)
    {

    }

    public void CubeSort(int[] nums)
    {

    }

    public void StrandSort(int[] nums)
    {

    }

    public void LibrarySort(int[] nums)
    {

    }

    public void PatienceSort(int[] nums)
    {

    }

    public void Introsort(int[] nums)
    {

    }

    public void BlockSort(int[] nums)
    {

    }

    public void BozoSort(int[] nums)
    {

    }

}