namespace Algorithm.LeetCode;

public class LessThanSum
{

    public int Process(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }
        return this.Process(nums, 0, nums.Length - 1);
    }


    public int Process(int[] nums, int leftIndex, int rightIndex)
    {
        if (leftIndex == rightIndex)
        {
            return 0;
        }

        int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
        int leftSumary = this.Process(nums, leftIndex, middleIndex);
        int rightSumary = this.Process(nums, middleIndex + 1, rightIndex);
        int mergeSumary = this.Merge(nums, leftIndex, middleIndex, rightIndex);
        return leftSumary + rightSumary + mergeSumary;
    }

    public int Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex)
    {
        int[] helpArray = new int[rightIndex - leftIndex + 1];
        int helpArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1, samllSumary = 0;
        while (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
        {
            if (nums[leftHelpIndex] < nums[rightHelpIndex])
            {
                samllSumary += nums[leftHelpIndex] * (rightIndex - rightHelpIndex + 1);
                helpArray[helpArrayIndex++] = nums[leftHelpIndex++];
            }
            else
            {
                helpArray[helpArrayIndex++] = nums[rightHelpIndex++];
            }
        }

        while (leftHelpIndex <= middleIndex)
        {
            helpArray[helpArrayIndex++] = nums[leftHelpIndex++];
        }

        while (rightHelpIndex <= rightIndex)
        {
            helpArray[helpArrayIndex++] = nums[rightHelpIndex++];
        }

        for (int i = 0; i < helpArray.Length; i++)
        {
            nums[leftIndex + i] = helpArray[i];
        }

        return samllSumary;
    }
}
