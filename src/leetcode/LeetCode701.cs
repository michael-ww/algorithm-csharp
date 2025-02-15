namespace Algorithm.LeetCode;

public class LeetCode701
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null)
        {
            root = new(val);
        }
        else
        {
            if (root.Value > val)
            {
                root.Left = this.InsertIntoBST(root.Left, val);
            }
            else
            {
                root.Right = this.InsertIntoBST(root.Right, val);
            }
        }
        return root;
    }
}
