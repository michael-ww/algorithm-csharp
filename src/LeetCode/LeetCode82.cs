namespace Belly.Algorithm.LeetCode;

public class LeetCode82
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        ArgumentNullException.ThrowIfNull(head.Next);
        ListNode current = head;
        while (current != null && current.Next != null)
        {
            if (current.Value == current.Next.Value)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        }

        return head;
    }
}