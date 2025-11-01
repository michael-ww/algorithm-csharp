namespace Belly.Algorithm.LeetCode;

public class LeetCode167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else
            {
                return [left + 1, right + 1];
            }
        }

        return [-1, -1];
    }
}
