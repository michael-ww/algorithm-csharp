namespace Belly.Algorithm.LeetCode;

public class LeetCode145
{
    public IList<int> PostorderTraversal1(TreeNode root)
    {
        List<int> answer = [];
        if (root == null)
        {
            return answer;
        }
        this.PostorderTraversal(answer, root);
        return answer;
    }

    private void PostorderTraversal(IList<int> list, TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        this.PostorderTraversal(list, root.Left);
        this.PostorderTraversal(list, root.Right);
        list.Add(root.Value);
    }

    public IList<int> PostorderTraversal2(TreeNode root)
    {
        List<int> answer = new();
        if (root == null)
        {
            return answer;
        }

        Stack<TreeNode> stack1 = new();
        Stack<TreeNode> stack2 = new();
        stack1.Push(root);
        while (stack1.Count > 0)
        {
            TreeNode node = stack1.Pop();
            stack2.Push(node);
            if (node.Left != null)
            {
                stack1.Push(node.Left);
            }
            if (node.Right != null)
            {
                stack1.Push(node.Right);
            }
        }

        while (stack2.Count > 0)
        {
            TreeNode node = stack2.Pop();
            answer.Add(node.Value);
        }

        return answer;
    }

    public IList<int> PostorderTraversal3(TreeNode root)
    {
        List<int> answer = new();
        if (root == null)
        {
            return answer;
        }

        TreeNode current = root;
        while (current != null)
        {
            TreeNode mostRight = current.Left;
            if (mostRight != null)
            {
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
                    this.PrintReversingRightEdge(current.Left, answer);
                }
            }
            current = current.Right;
        }
        this.PrintReversingRightEdge(root, answer);
        return answer;
    }

    private void PrintReversingRightEdge(TreeNode from, IList<int> answer)
    {
        TreeNode tail = this.ReverseRightEdge(from);
        TreeNode current = tail;
        while (current != null)
        {
            answer.Add(current.Value);
            current = current.Right;
        }
        this.ReverseRightEdge(tail);
    }

    private TreeNode ReverseRightEdge(TreeNode from)
    {
        TreeNode previous = null, next = null;
        while (from != null)
        {
            next = from.Right;
            from.Right = previous;
            previous = from;
            from = next;
        }
        return previous;
    }
}
