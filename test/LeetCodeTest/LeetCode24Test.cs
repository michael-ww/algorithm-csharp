namespace Algorithm.LeetCodeTest;

public class LeetCode24Test
{
    [Fact]
    public void SwapPairs1_ValidInput_ReturnHead()
    {
        // Given
        ListNode ln5 = new(42);
        ListNode ln4 = new(10, ln5);
        ListNode ln3 = new(7, ln4);
        ListNode ln2 = new(3, ln3);
        ListNode ln1 = new(-1, ln2);

        // When
        ListNode answer = new LeetCode24().SwapPairs1(ln1);

        // Then
        Assert.Equal(3, answer.Value);
    }

    [Fact]
    public void SwapPairs2_ValidInput_ReturnHead()
    {
        // Given
        ListNode ln5 = new(42);
        ListNode ln4 = new(10, ln5);
        ListNode ln3 = new(7, ln4);
        ListNode ln2 = new(3, ln3);
        ListNode ln1 = new(-1, ln2);

        // When
        ListNode answer = new LeetCode24().SwapPairs2(ln1);

        // Then
        Assert.Equal(3, answer.Value);
    }
}
