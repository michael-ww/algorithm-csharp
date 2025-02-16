namespace Belly.Algorithm.LeetCode;

public class LeetCode160
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null)
        {
            return null;
        }

        ListNode loopA = this.GetLoopNode(headA);
        ListNode loopB = this.GetLoopNode(headB);

        if (loopA == null && loopB == null)
        {
            return this.GetNoLoopIntersectionNode(headA, headB);
        }
        else if (loopA != null && loopB != null)
        {
            return this.GetBothLoopIntersectionNode(headA, loopA, headB, loopB);
        }
        else
        {
            return null;
        }
    }

    private ListNode GetNoLoopIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null)
        {
            return null;
        }

        ListNode currentA = headA;
        int nodeCount = 0;
        while (currentA.Next != null)
        {
            nodeCount++;
            currentA = currentA.Next;
        }

        ListNode currentB = headB;
        while (currentB.Next != null)
        {
            nodeCount--;
            currentB = currentB.Next;
        }

        if (currentA != currentB)
        {
            return null;
        }

        currentA = nodeCount > 0 ? headA : headB;
        currentB = currentA == headA ? headB : headA;
        nodeCount = Math.Abs(nodeCount);
        while (nodeCount != 0)
        {
            nodeCount--;
            currentA = currentA.Next;
        }

        while (currentA != currentB)
        {
            currentA = currentA.Next;
            currentB = currentB.Next;
        }

        return currentA;
    }

    private ListNode GetBothLoopIntersectionNode(ListNode headA, ListNode loopA, ListNode headB, ListNode loopB)
    {
        if (headA == null || loopA == null || headB == null || loopB == null)
        {
            return null;
        }

        if (loopA == loopB)
        {
            ListNode currentA = headA;
            int nodeCount = 0;
            while (currentA != loopA)
            {
                nodeCount++;
                currentA = currentA.Next;
            }

            ListNode currentB = headB;
            while (currentB != loopB)
            {
                nodeCount--;
                currentB = currentB.Next;
            }

            currentA = nodeCount > 0 ? headA : headB;
            currentB = currentA == headA ? headB : headA;
            nodeCount = Math.Abs(nodeCount);
            while (nodeCount > 0)
            {
                nodeCount--;
                currentA = currentA.Next;
            }

            while (currentA != currentB)
            {
                currentA = currentA.Next;
                currentB = currentB.Next;
            }

            return currentA;
        }
        else
        {
            ListNode currentA = loopA.Next;
            while (currentA != loopA)
            {
                if (currentA == loopB)
                {
                    return loopA;
                }
                currentA = currentA.Next;
            }
            return null;
        }
    }

    private ListNode GetLoopNode(ListNode head)
    {
        if (head == null || head.Next == null || head.Next.Next == null)
        {
            return null;
        }

        ListNode fast = head.Next.Next, slow = head.Next;
        while (fast != slow)
        {
            if (fast.Next == null || fast.Next.Next == null)
            {
                return null;
            }
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        fast = head;
        while (fast != slow)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        return fast;
    }
}
