namespace Belly.Algorithm.LeetCode;

public class LeetCode25
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null || head.Next == null || k < 2)
        {
            return head;
        }

        ListNode dummy = new(0)
        {
            Next = head
        };
        ListNode previous = dummy;
        while (head != null)
        {
            ListNode tail = previous;
            for (int i = 0; i < k; i++)
            {
                tail = tail.Next;
                if (tail == null)
                {
                    return dummy.Next;
                }
            }
            ListNode next = tail.Next;
            tail.Next = null;
            previous.Next = Utility.Reverse(head);
            head.Next = next;
            previous = head;
            head = next;
        }

        return dummy.Next;
    }
}
