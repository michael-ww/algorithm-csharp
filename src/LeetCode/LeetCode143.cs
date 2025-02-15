namespace Algorithm.LeetCode;

public class LeetCode143
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public ListNode ReorderList(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        ListNode fast = head, slow = head;
        while (fast.Next != null && fast.Next.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        ListNode end = this.Reverse(slow.Next);
        slow.Next = null;
        ListNode current = head;
        while (current != null && end != null)
        {
            ListNode cNext = current.Next;
            ListNode eNext = end.Next;
            current.Next = end;
            end.Next = cNext;
            current = cNext;
            end = eNext;
        }

        return head;
    }

    private ListNode Reverse(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        ListNode previous = null;
        while (head != null)
        {
            ListNode next = head.Next;
            head.Next = previous;
            previous = head;
            head = next;
        }
        return previous;
    }
}
