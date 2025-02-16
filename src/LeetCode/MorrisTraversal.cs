namespace Belly.Algorithm.LeetCode;

//Time Complexity: O(N)
//Space Complexity: O(1)
public class MorrisTraversal
{
    public void Traversal(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        TreeNode current = root;
        while (current != null)
        {
            TreeNode mostRight = current.Left;
            while (mostRight.Right != null && mostRight.Right != current)
            {
                mostRight = mostRight.Right;
            }
            if (mostRight.Right == null)
            {
                mostRight.Right = current;
                current = current.Left;
                continue;
            }
            else
            {
                mostRight.Right = null;
            }

            current = current.Right;
        }
    }
}
