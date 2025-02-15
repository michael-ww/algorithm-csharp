namespace Algorithm.LeetCode;

public class LeetCode315
{
    public int[] CountSmaller(int[] nums)
    {
        int[] answer = new int[nums.Length];
        if (nums == null || nums.Length <= 0)
        {
            return answer;
        }
        this.Process(nums, 0, nums.Length - 1, answer);
        return answer;
    }

    private void Process(int[] nums, int leftIndex, int rightIndex, int[] answer)
    {
        if (leftIndex == rightIndex)
        {
            return;
        }
        int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
        this.Process(nums, leftIndex, middleIndex, answer);
        this.Process(nums, middleIndex + 1, rightIndex, answer);
        this.Merge(nums, leftIndex, middleIndex, rightIndex, answer);
    }

    private void Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex, int[] answer)
    {
        int[] orderArray = new int[rightIndex - leftIndex + 1];
        int left = leftIndex, right = middleIndex + 1, index = 0;
        while (left <= middleIndex && right <= rightIndex)
        {
            if (nums[left] > nums[right])
            {
                answer[left]++;
                orderArray[index++] = nums[right++];
            }
            else if (nums[left] < nums[right])
            {
                orderArray[index++] = nums[left++];
            }
            else
            {
                orderArray[index++] = nums[right++];
            }
        }

        while (left <= middleIndex)
        {
            orderArray[index++] = nums[left++];
        }
        while (right <= rightIndex)
        {
            orderArray[index++] = nums[right++];
        }

        for (int i = 0; i < orderArray.Length; i++)
        {
            nums[leftIndex + i] = orderArray[i];
        }
    }
}
