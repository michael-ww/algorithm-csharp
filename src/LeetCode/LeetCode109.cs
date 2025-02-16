namespace Belly.Algorithm.LeetCode;

public class LeetCode109
{
    // Time Complexity: O(nlogn)
    // Space Complexity: O(logn)
    public TreeNode SortedListToBST(ListNode head)
    {
        ArgumentNullException.ThrowIfNull(head);
        return this.BuildTree(head, null);
    }

    private TreeNode BuildTree(ListNode head, ListNode end)
    {
        if (head == end)
        {
            return null;
        }

        ListNode middle = this.GetMiddle(head, end);
        TreeNode tn = new(middle.Value)
        {
            Left = this.BuildTree(head, middle),
            Right = this.BuildTree(middle.Next, end)
        };
        return tn;
    }

    private ListNode GetMiddle(ListNode head, ListNode end)
    {
        ListNode slow = head, fast = head;
        while (fast != end && fast.Next != end)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow;
    }
}
