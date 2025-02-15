namespace Algorithm.LeetCode.Test
{
    public class LeetCode328Test
    {
        [Fact]
        public void OddEvenList_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln9 = new(9);
            ListNode ln8 = new(8, ln9);
            ListNode ln7 = new(7, ln8);
            ListNode ln6 = new(6, ln7);
            ListNode ln5 = new(5, ln6);
            ListNode ln4 = new(4, ln5);
            ListNode ln3 = new(3, ln4);
            ListNode ln2 = new(2, ln3);
            ListNode ln1 = new(1, ln2);

            // When
            ListNode answer = new LeetCode328().OddEvenList(ln1);

            // Then
            Assert.Equal(3, answer.Next.Value);
        }
    }
}