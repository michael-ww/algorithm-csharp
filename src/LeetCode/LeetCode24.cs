namespace Belly.Algorithm.LeetCode;

public class LeetCode24
{
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public ListNode SwapPairs1(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }
        ListNode newHead = head.Next;
        head.Next = this.SwapPairs1(newHead.Next);
        newHead.Next = head;
        return newHead;
    }

    public ListNode SwapPairs2(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNode dummy = new(0)
        {
            Next = head,
        };
        ListNode current = dummy;
        while (current.Next != null && current.Next.Next != null)
        {
            ListNode ln1 = current.Next;
            ListNode ln2 = current.Next.Next;
            current.Next = ln2;
            ln1.Next = ln2.Next;
            ln2.Next = ln1;
            current = ln1;
        }
        return dummy.Next;
    }
}
