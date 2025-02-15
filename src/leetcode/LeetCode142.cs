namespace Algorithm.LeetCode;

public class LeetCode142
{
    public ListNode DetectCycle1(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return null;
        }
        HashSet<ListNode> nodes = new();
        ListNode current = head;
        while (current != null)
        {
            if (nodes.Contains(current))
            {
                return current;
            }
            else
            {
                nodes.Add(current);
            }
            current = current.Next;
        }

        return null;
    }

    public ListNode DetectCycle2(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return null;
        }

        ListNode fast = head.Next, slow = head;
        while (!fast.Equals(slow))
        {
            if (fast.Next == null || fast.Next.Next == null)
            {
                return null;
            }
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        fast = head;
        while (!fast.Equals(slow))
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        return fast;
    }
}
