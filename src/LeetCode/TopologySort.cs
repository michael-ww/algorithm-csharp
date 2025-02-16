namespace Belly.Algorithm.LeetCode;

public class TopologySort
{
    public Node[] Process(Graph graph)
    {
        List<Node> answer = new();
        if (graph == null || graph.Nodes == null || graph.Edges == null)
        {
            return answer.ToArray();
        }

        Queue<Node> zeroInQueue = new();
        Dictionary<Node, int> inMap = new();

        foreach (var item in graph.Nodes.Values)
        {
            inMap.Add(item, item.In);
            if (item.In == 0)
            {
                zeroInQueue.Enqueue(item);
            }
        }

        while (zeroInQueue.Count > 0)
        {
            Node current = zeroInQueue.Dequeue();
            answer.Add(current);
            foreach (var item in current.Nexts)
            {
                inMap.Add(item, inMap[item] - 1);
                if (inMap[item] == 0)
                {
                    zeroInQueue.Enqueue(item);
                }
            }
        }

        return answer.ToArray();
    }
}
