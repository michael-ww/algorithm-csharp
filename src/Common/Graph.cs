namespace Belly.Algorithm.Common;

public class Graph(Dictionary<int, Node> nodes, HashSet<Edge> edges)
{
    public Dictionary<int, Node> Nodes { get; } = nodes;

    public HashSet<Edge> Edges { get; } = edges;
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

public class Edge(int weight, Node from, Node to) : IComparer<Edge>
{
    public int Weight { get; } = weight;

    public Node From { get; } = from;

    public Node To { get; } = to;

    public int Compare(Edge x, Edge y)
    {
        return x.Weight - y.Weight;
    }
}
