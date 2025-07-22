namespace Belly.Algorithm.LeetCode;

public class Graph
{
    public Dictionary<int, Node> Nodes { get; }

    public HashSet<Edge> Edges { get; }

    public Graph(Dictionary<int, Node> nodes, HashSet<Edge> edges)
    {
        this.Nodes = nodes;
        this.Edges = edges;
    }
}

public class Node
{
    public int Value { get; }

    public int In { get; }

    public int Out { get; }

    public List<Node> Nexts { get; }

    public List<Edge> Edges { get; }

    public Node(int value)
    {
        this.Value = value;
        this.In = 0;
        this.Out = 0;
        this.Nexts = [];
        this.Edges = [];
    }
}

public class Edge : IComparer<Edge>
{
    public int Weight { get; }

    public Node From { get; }

    public Node To { get; }

    public Edge(int weight, Node from = null, Node to = null)
    {
        this.Weight = weight;
        this.From = from;
        this.To = to;
    }

    public int Compare(Edge x, Edge y)
    {
        return x.Weight - y.Weight;
    }
}
