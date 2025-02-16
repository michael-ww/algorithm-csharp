namespace Belly.Algorithm.LeetCode;

public class LeetCode445
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if (l1 == null)
        {
            return l2;
        }
        if (l2 == null)
        {
            return l1;
        }

        ListNode ln1 = Utility.Reverse(l1);
        ListNode ln2 = Utility.Reverse(l2);
        ListNode dummy = new(0);
        ListNode current = dummy;
        int carryNumber = 0;
        while (ln1 != null || ln2 != null)
        {
            int x = ln1 == null ? 0 : ln1.Value;
            int y = ln2 == null ? 0 : ln2.Value;
            int z = x + y + carryNumber;
            current.Next = new(z % 10);
            carryNumber = z / 10;
            current = current.Next;
            if (ln1 != null)
            {
                ln1 = ln1.Next;
            }
            if (ln2 != null)
            {
                ln2 = ln2.Next;
            }
        }
        if (carryNumber > 0)
        {
            current.Next = new(carryNumber);
        }
        return Utility.Reverse(dummy.Next);
    }
}
