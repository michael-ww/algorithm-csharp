namespace Algorithm.LeetCode;

public class LeetCode203
{
    public ListNode RemoveElements1(ListNode head, int val)
    {
        if (head == null)
        {
            return null;
        }
        ListNode answer = new(0, head);
        ListNode current = answer;
        while (current.Next != null)
        {
            if (current.Next.Value == val)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        }

        return answer.Next;
    }

    public ListNode RemoveElements2(ListNode head, int val)
    {
        if (head == null)
        {
            return head;
        }
        head.Next = this.RemoveElements2(head.Next, val);
        return head.Value == val ? head.Next : head;
    }
}
