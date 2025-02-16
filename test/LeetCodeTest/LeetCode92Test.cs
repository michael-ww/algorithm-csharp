namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode92Test
{
    [Fact]
    public void ReverseBetween_ValidInput1_ReturnHead()
    {
        //Arrange
        ListNode tail = new(5, null);
        ListNode fouth = new(4, tail);
        ListNode third = new(3, fouth);
        ListNode second = new(2, third);
        ListNode head = new(1, second);

        //Act
        LeetCode92 leetCode92 = new();
        ListNode answer = leetCode92.ReverseBetween(head, 2, 4);


        //Assert
        Assert.Equal(4, answer.Next.Value);
    }
}
