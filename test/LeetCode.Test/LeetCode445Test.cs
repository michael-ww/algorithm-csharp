namespace Algorithm.LeetCode.Test
{
    public class LeetCode445Test
    {
        [Fact]
        public void AddTwoNumbers_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln13 = new(5);
            ListNode ln12 = new(4, ln13);
            ListNode ln11 = new(6, ln12);

            ListNode ln25 = new(9);
            ListNode ln24 = new(4, ln25);
            ListNode ln23 = new(7, ln24);
            ListNode ln22 = new(6, ln23);
            ListNode ln21 = new(8, ln22);


            // When
            ListNode answer = new LeetCode445().AddTwoNumbers(ln11, ln21);

            // Then
            Assert.Equal(8, answer.Value);
        }
    }
}