namespace Belly.Algorithm.LeetCode;

public class LeetCode148
{
    // Time Complexity: O(n^2)
    // Space Complexity: O(n)
    public ListNode SortList1(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        if (head.Next == null)
        {
            return head;
        }

        int nodeCount = 0;
        ListNode current = head;
        while (current != null)
        {
            nodeCount++;
            current = current.Next;
        }

        ListNode[] nodes = new ListNode[nodeCount];
        current = head;
        while (current != null)
        {
            nodeCount--;
            nodes[nodeCount] = current;
            current = current.Next;
        }

        Array.Sort(nodes);

        for (int i = 0; i < nodes.Length - 1; i++)
        {
            nodes[i].Next = nodes[i + 1];
        }
        nodes[nodes.Length - 1].Next = null;
        return nodes[0];
    }

    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    public ListNode SortList2(ListNode head)
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

        ListNode current = head.Next, sorted = head;
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
                sorted.Next = current.Next;
                ListNode next = previous.Next;
                previous.Next = current;
                current.Next = next;
            }
            current = sorted.Next;
        }

        return dummy.Next;
    }

    public ListNode SortList3(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        if (head.Next == null)
        {
            return head;
        }
        ListNode current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        return this.Process(head, current);
    }

    private ListNode Process(ListNode left, ListNode right)
    {
        if (left == null)
        {
            return null;
        }
        if (left == right || left.Next == right)
        {
            left.Next = null;
            return left;
        }
        ListNode middle = this.GetMiddleNode(left, right);
        ListNode ln1 = this.Process(left, middle);
        ListNode ln2 = this.Process(middle.Next, right);
        ListNode ln = this.Merge(ln1, ln2);
        return ln;
    }

    private ListNode Merge(ListNode ln1, ListNode ln2)
    {
        ListNode dummy = new(0);
        ListNode current = dummy;
        while (ln1 != null && ln2 != null)
        {
            if (ln1.Value <= ln2.Value)
            {
                current.Next = ln1;
                ln1 = ln1.Next;
            }
            else
            {
                current.Next = ln2;
                ln2 = ln2.Next;
            }
            current = current.Next;
        }
        if (ln1 != null)
        {
            current.Next = ln1;
        }
        if (ln2 != null)
        {
            current.Next = ln2;
        }
        return dummy.Next;
    }



    private ListNode GetMiddleNode(ListNode left, ListNode right)
    {
        ListNode fast = left, slow = left;
        while (fast != right && fast.Next != right)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }
        return slow;
    }
}
