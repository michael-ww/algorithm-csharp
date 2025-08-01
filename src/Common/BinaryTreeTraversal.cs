namespace Belly.Algorithm.Common;

public class BinaryTreeTraversal
{
    // recurring order (first print second print third print)
    // preoder(head left right) first print
    // inorder(left head right) second print
    // postorder(left right head) third print
    public void RecuringOrder(TreeNode root)
    {
        Console.WriteLine("Recurring Order:");
        if (root == null)
        {
            return;
        }
        Console.Write(root.Value); // first print
        this.RecuringOrder(root.Left);
        Console.Write(root.Value); // second print
        this.RecuringOrder(root.Right);
        Console.Write(root.Value); // third print
    }

    public void Preorder(TreeNode root)
    {
        Console.WriteLine("Preorder:");
        if (root == null)
        {
            return;
        }

        Stack<TreeNode> stack = new();
        stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            Console.Write(node.Value);
            if (node.Right != null)
            {
                stack.Push(node.Right);
            }
            if (node.Left != null)
            {
                stack.Push(node.Left);
            }
        }
    }

    public void Inorder(TreeNode root)
    {
        Console.WriteLine("Inorder:");
        if (root == null)
        {
            return;
        }
        Stack<TreeNode> stack = new();
        while (stack.Count > 0 || root != null)
        {
            if (root != null)
            {
                stack.Push(root);
                root = root.Left;
            }
            else
            {
                root = stack.Pop();
                Console.Write(root.Value);
                root = root.Right;
            }
        }
    }

    public void Postorder(TreeNode root)
    {
        Console.WriteLine("Postorder:");
        if (root == null)
        {
            return;
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
            Console.Write(node.Value);
        }
    }

    public void Width(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            Console.Write(node.Value);
            if (node.Left != null)
            {
                queue.Enqueue(node.Left);
            }
            if (node.Right != null)
            {
                queue.Enqueue(node.Right);
            }
        }
    }
}
