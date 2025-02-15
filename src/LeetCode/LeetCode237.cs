namespace Algorithm.LeetCode;

public class LeetCode237
{
    public void DeleteNode(ListNode node)
    {
        ArgumentNullException.ThrowIfNull(node);
        ArgumentNullException.ThrowIfNull(node.Next);
        node.Value = node.Next.Value;
        node.Next = node.Next.Next;
    }
}
