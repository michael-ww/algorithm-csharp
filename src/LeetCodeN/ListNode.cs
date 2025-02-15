namespace Algorithm.LeetCode;

public class ListNode
{
    public int Value { get; set; }

    public ListNode Next { get; set; }

    public ListNode Previous { get; set; }

    public ListNode Random { get; set; }

    public ListNode(int value = default, ListNode next = null)
    {
        this.Value = value;
        this.Next = next;
    }

}
