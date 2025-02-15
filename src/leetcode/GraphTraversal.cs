namespace Algorithm.LeetCode;

public class GraphTraversal
{
    public void BFS(Node node)
    {
        if (node == null)
        {
            return;
        }
        Queue<Node> queue = new();
        queue.Enqueue(node);
        HashSet<Node> set = new();
        set.Add(node);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            //process current node
            foreach (var item in current.Nexts)
            {
                if (!set.Contains(item))
                {
                    queue.Enqueue(item);
                    set.Add(item);
                }
            }
        }
    }

    public void DFS(Node node)
    {
        if (node == null)
        {
            return;
        }
        Stack<Node> stack = new();
        stack.Push(node);
        HashSet<Node> set = new();
        set.Add(node);
        //Process Current Node
        while (stack.Count > 0)
        {
            Node current = stack.Pop();
            foreach (var item in current.Nexts)
            {
                if (!set.Contains(item))
                {
                    stack.Push(current);
                    stack.Push(item);
                    set.Add(item);
                    //Process Next Node
                    break;
                }
            }
        }
    }
}
