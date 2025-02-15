namespace Algorithm.LeetCodeTest
{
    public class LeetCode203Test
    {
        [Fact]
        public void RemoveElements1_ValidInput_ReturnHead()
        {
            // Given
            ListNode tail = new(4, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(2, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            // When
            ListNode answer = new LeetCode203().RemoveElements1(head, 4);

            // Then
            Assert.Null(answer.Next.Next.Next);
        }

        [Fact]
        public void RemoveElements2_ValidInput_ReturnHead()
        {
            // Given
            ListNode tail = new(4, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(2, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            // When
            ListNode answer = new LeetCode203().RemoveElements2(head, 4);

            // Then
            Assert.Null(answer.Next.Next.Next);
        }
    }
}