namespace Belly.Algorithm.LeetCode;

public class LeetCode23
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> pq = new();
        for (int i = 0; i < lists.Length; i++)
        {
            pq.Enqueue(lists[i], lists[i].Value);
        }
        ListNode dummy = new(0);
        ListNode current = dummy;
        while (pq.Count > 0)
        {
            current.Next = pq.Dequeue();
            current = current.Next;
            if (current.Next != null)
            {
                pq.Enqueue(current.Next, current.Next.Value);
            }
        }

        return dummy.Next;
    }
}