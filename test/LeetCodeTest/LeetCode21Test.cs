namespace Algorithm.LeetCodeTest;

public class LeetCode21Test
{
    [Fact]
    public void MergeTwoLists_ValidInput_ReturnList()
    {
        // Given
        ListNode ln13 = new(5);
        ListNode ln12 = new(4, ln13);
        ListNode ln11 = new(1, ln12);

        ListNode ln25 = new(42);
        ListNode ln24 = new(10, ln25);
        ListNode ln23 = new(7, ln24);
        ListNode ln22 = new(3, ln23);
        ListNode ln21 = new(-1, ln22);

        // When
        ListNode answer = new LeetCode21().MergeTwoLists(ln11, ln21);

        // Then
        Assert.Equal(-1, answer.Value);
        Assert.Equal(1, answer.Next.Value);
        Assert.Equal(3, answer.Next.Next.Value);
        Assert.Equal(4, answer.Next.Next.Next.Value);
        Assert.Equal(5, answer.Next.Next.Next.Next.Value);
        Assert.Equal(7, answer.Next.Next.Next.Next.Next.Value);
    }
}
