namespace Belly.Algorithm.LeetCode;

public class LeetCode86
{
    public ListNode Partition1(ListNode head, int pivot)
    {
        ArgumentNullException.ThrowIfNull(head);

        ListNode lessHead = null, lessTail = null;
        ListNode equalHead = null, equalTail = null;
        ListNode moreHead = null, moreTail = null;
        ListNode current = head;
        while (current != null)
        {
            if (current.Value > pivot)
            {
                if (moreHead == null)
                {
                    moreHead = current;
                }
                else
                {
                    moreTail.Next = current;
                }
                moreTail = current;
            }
            else if (current.Value == pivot)
            {
                if (equalHead == null)
                {
                    equalHead = current;
                }
                else
                {
                    equalTail.Next = current;
                }
                equalTail = current;
            }
            else
            {
                if (lessHead == null)
                {
                    lessHead = current;
                }
                else
                {
                    lessTail.Next = current;
                }
                lessTail = current;
            }
            current = current.Next;
        }

        if (lessTail != null)
        {
            lessTail.Next = equalHead;
            equalTail = equalTail ?? lessTail;
        }

        if (equalTail != null)
        {
            equalTail.Next = moreHead;
        }

        return lessHead ?? equalHead ?? moreHead;
    }

    public ListNode Partition2(ListNode head, int pivot)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNode current = head;
        int nodeCount = 0;
        while (current != null)
        {
            nodeCount++;
            current = current.Next;
        }

        ListNode[] nodes = new ListNode[nodeCount];
        current = head;
        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i] = current;
            current = current.Next;
        }

        int index = 0, lessPosition = -1, morePosition = nodes.Length;
        while (index < morePosition)
        {
            if (nodes[index].Value < pivot)
            {
                Utility.Swap(nodes, index++, ++lessPosition);
            }
            else if (nodes[index].Value == pivot)
            {
                index++;
            }
            else
            {
                Utility.Swap(nodes, index, --morePosition);
            }
        }

        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i].Next = i + 1 < nodes.Length ? nodes[i + 1] : null;
        }

        return nodes[0];
    }
}
