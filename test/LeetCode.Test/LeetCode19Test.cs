namespace Algorithm.LeetCode.Test
{
    public class LeetCode19Test
    {
        [Fact]
        public void RemoveNthFromEnd1_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln5 = new(42);
            ListNode ln4 = new(10, ln5);
            ListNode ln3 = new(7, ln4);
            ListNode ln2 = new(3, ln3);
            ListNode ln1 = new(-1, ln2);

            // When
            LeetCode19 leetCode19 = new();
            ListNode answer = leetCode19.RemoveNthFromEnd1(ln1, 5);

            // Then
            Assert.Equal(3, answer.Value);
        }

        [Fact]
        public void RemoveNthFromEnd2_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln5 = new(42);
            ListNode ln4 = new(10, ln5);
            ListNode ln3 = new(7, ln4);
            ListNode ln2 = new(3, ln3);
            ListNode ln1 = new(-1, ln2);

            // When
            LeetCode19 leetCode19 = new();
            ListNode answer = leetCode19.RemoveNthFormEnd2(ln1, 5);

            // Then
            Assert.Null(answer.Next.Next.Next.Next);
        }
    }
}