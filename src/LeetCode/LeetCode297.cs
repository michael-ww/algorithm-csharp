namespace Belly.Algorithm.LeetCode;

using System.Globalization;

public class LeetCode297
{
    public string SerializeByPreorder(TreeNode root)
    {
        if (root is null)
        {
            return "null,";
        }
        string answer = $"{root.Value},";
        answer += this.SerializeByPreorder(root.Left);
        answer += this.SerializeByPreorder(root.Right);
        return answer;
    }

    public string SerializeByPostorder(TreeNode root)
    {
        if (root is null)
        {
            return "null,";
        }
        string answer = this.SerializeByPostorder(root.Left);
        answer += this.SerializeByPostorder(root.Right);
        answer += $"{root.Value},";
        return answer;
    }

    public TreeNode DeserializeByPreorder(string data)
    {
        if (string.IsNullOrWhiteSpace(data))
        {
            return null;
        }
        string[] nodes = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
        Queue<string> queue = new(nodes);
        return this.DeserializeByPreorder(queue);
    }

    public TreeNode DeserializeByPreorder(Queue<string> queue)
    {
        string node = queue.Dequeue();
        if (node == "null")
        {
            return null;
        }
        TreeNode root = new(int.Parse(node, NumberStyles.Integer))
        {
            Left = this.DeserializeByPreorder(queue),
            Right = this.DeserializeByPreorder(queue)
        };
        return root;
    }

    public TreeNode DeserializeByPostorder(string data)
    {
        if (string.IsNullOrWhiteSpace(data))
        {
            return null;
        }
        string[] nodes = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
        Stack<string> stack = new(nodes);
        return this.DeserializeByPostorder(stack);
    }

    public TreeNode DeserializeByPostorder(Stack<string> stack)
    {
        string item = stack.Pop();
        if (item == "null")
        {
            return null;
        }
        TreeNode right = this.DeserializeByPostorder(stack);
        TreeNode left = this.DeserializeByPostorder(stack);
        TreeNode parent = new(int.Parse(item, NumberStyles.Integer))
        {
            Left = left,
            Right = right
        };
        return parent;
    }

    public string SerializeByLevelOrder(TreeNode root)
    {
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        StringBuilder sb = new();
        while (queue.Count > 0)
        {
            TreeNode tn = queue.Dequeue();
            if (tn is null)
            {
                sb.Append("null,");
            }
            else
            {
                sb.Append($"{tn.Value},");
                queue.Enqueue(tn.Left);
                queue.Enqueue(tn.Right);
            }
        }

        return sb.ToString().TrimEnd(',');
    }

    public TreeNode DeserializeByLevelOrder(string data)
    {
        string[] elements = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
        Queue<string> nodes = new(elements);
        string rootValue = nodes.Dequeue();
        TreeNode root = new(int.Parse(rootValue, NumberStyles.Integer));
        Queue<TreeNode> treeNodes = new();
        treeNodes.Enqueue(root);
        while (treeNodes.Count > 0)
        {
            TreeNode parent = treeNodes.Dequeue();
            string leftValue = nodes.Dequeue();
            if (leftValue != "null")
            {
                parent.Left = new(int.Parse(leftValue, NumberStyles.Integer));
                treeNodes.Enqueue(parent.Left);
            }
            string rightValue = nodes.Dequeue();
            if (rightValue != "null")
            {
                parent.Right = new(int.Parse(rightValue, NumberStyles.Integer));
                treeNodes.Enqueue(parent.Right);
            }
        }

        return root;
    }
}
