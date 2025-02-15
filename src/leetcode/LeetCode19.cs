namespace Algorithm.LeetCode;

public class LeetCode19
{
    public ListNode RemoveNthFromEnd1(ListNode head, int n)
    {
        if (head == null || n <= 0)
        {
            return head;
        }

        int nodeCount = 0;
        ListNode current = head;
        while (current != null)
        {
            nodeCount++;
            current = current.Next;
        }

        if (nodeCount < n)
        {
            return head;
        }

        ListNode dummy = new(0)
        {
            Next = head
        };
        ListNode previous = dummy;
        current = head;
        int aimNode = nodeCount - n + 1;
        while (current != null)
        {
            aimNode--;
            if (aimNode == 0)
            {
                previous.Next = current.Next;
                break;
            }
            previous = current;
            current = current.Next;
        }

        return dummy.Next;
    }

    public ListNode RemoveNthFormEnd2(ListNode head, int n)
    {
        if (head == null || n <= 0)
        {
            return head;
        }

        ListNode current = head, previous = null, next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        ListNode dummy = new(0)
        {
            Next = previous,
        };
        current = previous;
        ListNode pprevious = dummy;
        while (current != null)
        {
            n--;
            if (n == 0)
            {
                pprevious.Next = current.Next;
                break;
            }
            pprevious = current;
            current = current.Next;
        }

        current = dummy.Next;
        previous = null;
        next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}
