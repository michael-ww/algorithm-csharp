namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode61Test
{
    [Fact]
    public void RotateRight_ValidInput_ReturnHead()
    {
        // Given
        ListNode ln5 = new(42);
        ListNode ln4 = new(10, ln5);
        ListNode ln3 = new(7, ln4);
        ListNode ln2 = new(3, ln3);
        ListNode ln1 = new(-1, ln2);

        // When
        ListNode answer = new LeetCode61().RotateRight(ln1, 2);

        // Then
        Assert.Equal(10, answer.Value);
    }
}