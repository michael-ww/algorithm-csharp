namespace Belly.Algorithm.LeetCode;

public class LeetCode234
{
    public bool IsPalindrome1(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        ListNode current = head;
        Stack<ListNode> nodes = new();
        while (current != null)
        {
            nodes.Push(current);
            current = current.Next;
        }

        current = head;
        while (current != null)
        {
            if (nodes.Pop().Value != current.Value)
            {
                return false;
            }
            current = current.Next;
        }

        return true;
    }

    public bool IsPalindrome2(ListNode head)
    {
        if (head == null)
        {
            return false;
        }

        ListNode fast = head, slow = head;
        while (fast.Next != null && fast.Next.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        ListNode end = Utility.Reverse(slow.Next);
        ListNode left = head, right = end;
        bool answer = true;
        while (right != null)
        {
            if (right.Value != left.Value)
            {
                answer = false;
                break;
            }
            left = left.Next;
            right = right.Next;
        }
        slow.Next = Utility.Reverse(end);
        return answer;
    }
}
