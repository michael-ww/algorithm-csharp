namespace Algorithm.LeetCodeTest;

public class LeetCode148Test
{
    [Fact]
    public void SortList1_ValidInput_ReturnHead()
    {
        // Given
        ListNode ln9 = new(3);
        ListNode ln8 = new(6, ln9);
        ListNode ln7 = new(8, ln8);
        ListNode ln6 = new(1, ln7);
        ListNode ln5 = new(7, ln6);
        ListNode ln4 = new(4, ln5);
        ListNode ln3 = new(5, ln4);
        ListNode ln2 = new(2, ln3);
        ListNode ln1 = new(9, ln2);

        // When
        ListNode answer = new LeetCode148().SortList1(ln1);

        // Then
        Assert.Equal(1, answer.Value);
    }

    [Fact]
    public void SortList2_ValidInput_ReturnHead()
    {
        // Given
        ListNode ln9 = new(3);
        ListNode ln8 = new(6, ln9);
        ListNode ln7 = new(8, ln8);
        ListNode ln6 = new(1, ln7);
        ListNode ln5 = new(7, ln6);
        ListNode ln4 = new(4, ln5);
        ListNode ln3 = new(5, ln4);
        ListNode ln2 = new(2, ln3);
        ListNode ln1 = new(9, ln2);

        // When
        ListNode answer = new LeetCode148().SortList2(ln1);

        // Then
        Assert.Equal(1, answer.Value);
    }
}
