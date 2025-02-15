namespace Algorithm.LeetCode;

public class LeetCode167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        ArgumentNullException.ThrowIfNull(numbers);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(numbers.Length);
        int leftIndex = 0, rightIndex = numbers.Length - 1;
        while (leftIndex < rightIndex)
        {
            if (numbers[leftIndex] + numbers[rightIndex] > target)
            {
                rightIndex--;
            }
            else if (numbers[leftIndex] + numbers[rightIndex] < target)
            {
                leftIndex++;
            }
            else
            {
                return [leftIndex + 1, rightIndex + 1];
            }
        }

        return [-1, -1];
    }
}
