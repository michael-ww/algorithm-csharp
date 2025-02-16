namespace Belly.Algorithm.LeetCode;

public class LeetCode147
{
    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    public ListNode InsertionSortList(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        if (head.Next == null)
        {
            return head;
        }

        ListNode dummy = new(0)
        {
            Next = head
        };
        ListNode current = head, sorted = head;
        while (current != null)
        {
            if (current.Value >= sorted.Value)
            {
                sorted = current;
            }
            else
            {
                ListNode previous = dummy;
                while (current.Value >= previous.Next.Value)
                {
                    previous = previous.Next;
                }
                ListNode next = previous.Next;
                sorted.Next = current.Next;
                previous.Next = current;
                current.Next = next;
            }
            current = sorted.Next;
        }

        return dummy.Next;
    }
}
