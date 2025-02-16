namespace Belly.Algorithm.LeetCode;

public class LeetCode629
{
    public int KInversePairs(int n, int k)
    {
        //TODO:
        return 0;
    }

    public IList<(int, int)> KInversePairs(int[] nums)
    {
        List<(int, int)> answer = new();
        if (nums == null || nums.Length < 2)
        {
            return answer;
        }

        return KInversePairs(nums, 0, nums.Length - 1);
    }

    private IList<(int, int)> KInversePairs(int[] nums, int leftIndex, int rightIndex)
    {
        if (leftIndex == rightIndex)
        {
            return null;
        }

        int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
        IList<(int, int)> leftPairs = this.KInversePairs(nums, leftIndex, middleIndex);
        IList<(int, int)> rightPairs = this.KInversePairs(nums, middleIndex + 1, rightIndex);
        IList<(int, int)> mergePairs = this.Merge(nums, leftIndex, middleIndex, rightIndex);
        return leftPairs.Union(rightPairs).Union(mergePairs).ToList();
    }

    private IList<(int, int)> Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex)
    {
        int[] orderedArray = new int[rightIndex - leftIndex + 1];
        int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1;
        List<(int, int)> inversePairs = new();
        while (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
        {
            if (nums[leftHelpIndex] > nums[rightHelpIndex])
            {
                inversePairs.Add((nums[leftHelpIndex], nums[rightHelpIndex]));
                orderedArray[orderedArrayIndex++] = nums[rightHelpIndex++];
            }
            else
            {
                orderedArray[orderedArrayIndex++] = nums[leftHelpIndex++];
            }
        }

        while (leftHelpIndex <= middleIndex)
        {
            orderedArray[orderedArrayIndex++] = nums[leftHelpIndex++];
        }
        while (rightHelpIndex <= rightIndex)
        {
            orderedArray[orderedArrayIndex++] = nums[rightHelpIndex++];
        }

        for (int i = 0; i < orderedArray.Length; i++)
        {
            nums[leftIndex + i] = orderedArray[i];
        }

        return inversePairs;
    }

    // public int Calculate(int[] array)
    // {
    //     if (array == null || array.Length < 2)
    //     {
    //         return 0;
    //     }
    //     return this.Process(array, 0, array.Length - 1);
    // }

    // public int Process(int[] array, int leftIndex, int rightIndex)
    // {
    //     if (leftIndex >= rightIndex)
    //     {
    //         return 0;
    //     }
    //     int middleIndex = leftIndex + ((rightIndex - leftIndex + 1) >> 1);
    //     int leftCount = this.Process(array, leftIndex, middleIndex);
    //     int rightCount = this.Process(array, middleIndex + 1, rightIndex);
    //     int mergeCount = this.Merge(array, leftIndex, middleIndex, rightIndex);
    //     return leftCount + rightCount + mergeCount;
    // }

    // public int Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
    // {
    //     int[] orderedArray = new int[rightIndex - leftIndex + 1];
    //     int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1, inversePairCount = 0;
    //     while (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
    //     {
    //         if (array[leftHelpIndex] > array[rightHelpIndex])
    //         {
    //             inversePairCount += middleIndex - leftHelpIndex + 1;
    //             array[orderedArrayIndex++] = array[rightHelpIndex++];
    //         }
    //         else
    //         {
    //             array[orderedArrayIndex++] = array[leftHelpIndex++];
    //         }
    //     }

    //     while (leftHelpIndex <= middleIndex)
    //     {
    //         array[orderedArrayIndex++] = array[leftHelpIndex++];
    //     }
    //     while (rightHelpIndex <= rightIndex)
    //     {
    //         array[orderedArrayIndex++] = array[rightHelpIndex++];
    //     }

    //     for (int i = 0; i < orderedArray.Length; i++)
    //     {
    //         array[leftIndex + i] = orderedArray[i];
    //     }

    //     return inversePairCount;
    // }
}
