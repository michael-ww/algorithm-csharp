namespace Belly.Algorithm.LeetCodeTest;

public class LeetCode206Test
{
    [Fact]
    public void ReverseList_ValidInput_ReturnHead()
    {
        //Arrange
        ListNode tail = new(5, null);
        ListNode fouth = new(4, tail);
        ListNode third = new(3, fouth);
        ListNode second = new(2, third);
        ListNode head = new(1, second);

        //Act
        LeetCode206 leetCode206 = new();
        ListNode answer = leetCode206.ReverseList(head);


        //Assert
        Assert.Equal(5, answer.Value);
    }
}
