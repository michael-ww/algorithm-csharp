namespace Belly.Algorithm.LeetCode;

public class LeetCode141
{
    public bool HasCycle1(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return false;
        }

        HashSet<ListNode> nodes = new();
        ListNode current = head;
        while (current != null)
        {
            if (nodes.Contains(current))
            {
                return true;
            }
            else
            {
                nodes.Add(current);
            }
        }

        return false;
    }

    public bool HasCycle2(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return false;
        }

        ListNode fast = head.Next, slow = head;
        while (!fast.Equals(slow))
        {
            if (fast.Next == null || fast.Next.Next == null)
            {
                return false;
            }
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        return true;
    }
}
