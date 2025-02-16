namespace Belly.Algorithm.LeetCode;

public class LeetCode61
{
    public ListNode RotateRight(ListNode head, int k)
    {
        ArgumentNullException.ThrowIfNull(head);
        ArgumentNullException.ThrowIfNull(head.Next);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(k);

        ListNode current = head;
        while (k > 0)
        {
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            ListNode next = current.Next;
            current.Next = null;
            next.Next = head;
            head = next;
            current = head;
            k--;
        }

        return head;
    }

}