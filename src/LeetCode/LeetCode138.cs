namespace Belly.Algorithm.LeetCode;

public class LeetCode138
{
    public ListNode CopyRandomList1(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        Dictionary<ListNode, ListNode> dictionary = new();
        ListNode current = head;
        while (current != null)
        {
            dictionary.Add(current, new ListNode(current.Value));
            current = current.Next;
        }
        current = head;
        while (current != null)
        {
            dictionary[current].Next = current.Next == null ? null : dictionary[current.Next];
            dictionary[current].Random = current.Random == null ? null : dictionary[current.Random];
            current = current.Next;
        }

        return dictionary[head];
    }

    public ListNode CopyRandomList2(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        ListNode current = head;
        while (current != null)
        {
            ListNode next = current.Next;
            current.Next = new ListNode((int)current.Value); ;
            current.Next.Next = next;
            current = next;
        }

        current = head;
        while (current != null)
        {
            current.Next.Random = current.Random?.Next;
            current = current.Next?.Next;
        }

        ListNode answer = head.Next;
        current = head;
        while (current != null)
        {
            ListNode next = current.Next.Next;
            ListNode copy = current.Next;
            current.Next = next;
            copy.Next = next.Next;
            current = next;
        }

        return answer;
    }
}
