namespace Belly.Algorithm.LeetCode;

public class LeetCode133
{
    private Dictionary<Node, Node> visited = new();

    public Node CloneGraph(Node node)
    {
        if (node == null)
        {
            return null;
        }

        if (visited.ContainsKey(node))
        {
            return visited[node];
        }

        Node clone = new Node(node.Value);
        foreach (var item in node.Nexts)
        {
            clone.Nexts.Add(this.CloneGraph(item));
        }

        visited.Add(node, clone);
        return clone;
    }
}
