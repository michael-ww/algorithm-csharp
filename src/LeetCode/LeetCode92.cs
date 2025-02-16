namespace Belly.Algorithm.LeetCode;

public class LeetCode92
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head == null || head.Next == null || left >= right || left < 0 || right < 0)
        {
            return head;
        }
        ListNode dummy = new(0)
        {
            Next = head
        };
        ListNode previous = dummy;
        for (int i = 0; i < left - 1; i++)
        {
            previous = previous.Next;
        }

        ListNode current = previous.Next;
        for (int i = 0; i < right - left; i++)
        {
            ListNode next = current.Next;
            current.Next = next.Next;
            next.Next = previous.Next;
            previous.Next = next;
        }

        return dummy.Next;
    }
}
