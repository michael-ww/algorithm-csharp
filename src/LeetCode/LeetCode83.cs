namespace Belly.Algorithm.LeetCode;

public class LeetCode83
{
    public ListNode DeleteDuplicates1(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }
        HashSet<int> hashSet = new();
        ListNode current = head, previous = head;
        while (current != null)
        {
            if (hashSet.Contains(current.Value))
            {
                previous.Next = current.Next;
            }
            else
            {
                hashSet.Add(current.Value);
                previous = current;
            }
            current = current.Next;
        }

        return head;
    }

    public ListNode DeleteDuplicates2(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

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
