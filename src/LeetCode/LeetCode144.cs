namespace Belly.Algorithm.LeetCode;

public class LeetCode144
{
    public IList<int> PreorderTraversal1(TreeNode root)
    {
        List<int> answer = [];
        if (root == null)
        {
            return answer;
        }
        this.PreorderTraversal1(answer, root);
        return answer;
    }

    private void PreorderTraversal1(IList<int> list, TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        list.Add(root.Value);
        this.PreorderTraversal1(list, root.Left);
        this.PreorderTraversal1(list, root.Right);
    }

    public IList<int> PreorderTraversal2(TreeNode root)
    {
        List<int> answer = [];
        if (root == null)
        {
            return answer;
        }
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            answer.Add(node.Value);
            if (node.Right != null)
            {
                stack.Push(node.Right);
            }
            if (node.Left != null)
            {
                stack.Push(node.Left);
            }
        }
        return answer;
    }

    public IList<int> PreorderTraversal3(TreeNode root)
    {
        List<int> answer = new();
        if (root == null)
        {
            return answer;
        }
        TreeNode current = root;
        while (current != null)
        {
            TreeNode mostRight = root.Left;
            if (mostRight == null)
            {
                answer.Add(current.Value);
            }
            else
            {
                while (mostRight.Right != null && mostRight.Right != current)
                {
                    mostRight = mostRight.Right;
                }
                if (mostRight.Right == null)
                {
                    answer.Add(current.Value);
                    mostRight.Right = current;
                    current = current.Left;
                    continue;
                }
                else
                {
                    mostRight.Right = null;
                }
            }
            current = current.Right;
        }
        return answer;
    }
}