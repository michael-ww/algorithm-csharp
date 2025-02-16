namespace Belly.Algorithm.LeetCode;

public class LeetCode328
{
    public ListNode OddEvenList(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        ListNode odd = head, evenHead = head.Next, even = evenHead;
        while (even != null && even.Next != null)
        {
            odd.Next = even.Next;
            odd = odd.Next;
            even.Next = odd.Next;
            even = even.Next;
        }
        odd.Next = evenHead;
        return head;
    }
}
