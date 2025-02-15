namespace Algorithm.LeetCode;

public class LeetCode108
{

    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return null;
        }
        return this.BST(nums, 0, nums.Length - 1);
    }

    private TreeNode BST(int[] nums, int leftIndex, int rightIndex)
    {
        if (leftIndex > rightIndex)
        {
            return null;
        }

        int middleIndex = (leftIndex + rightIndex) >> 1;
        TreeNode tn = new(nums[middleIndex])
        {
            Left = this.BST(nums, leftIndex, middleIndex - 1),
            Right = this.BST(nums, middleIndex + 1, rightIndex)
        };
        return tn;
    }
}
