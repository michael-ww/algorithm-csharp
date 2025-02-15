namespace Algorithm.LeetCode;

public class LeetCode21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }
        else if (list2 == null)
        {
            return list1;
        }
        else if (list1.Value < list2.Value)
        {
            list1.Next = this.MergeTwoLists(list1.Next, list2);
            return list1;
        }
        else
        {
            list2.Next = this.MergeTwoLists(list1, list2.Next);
            return list2;
        }
    }
}
