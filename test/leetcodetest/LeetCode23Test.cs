namespace Algorithm.LeetCodeTest
{
    public class LeetCode23Test
    {
        [Fact]
        public void MergeKLists_ValidInput_ReturnList()
        {
            // Given
            //[[1,4,5],[1,3,4],[2,6]]
            ListNode ln13 = new(5);
            ListNode ln12 = new(4, ln13);
            ListNode ln11 = new(1, ln12);

            ListNode ln23 = new(4);
            ListNode ln22 = new(3, ln23);
            ListNode ln21 = new(1, ln22);

            ListNode ln32 = new(6);
            ListNode ln31 = new(2, ln32);

            ListNode[] ListNodes = new ListNode[] { ln11, ln21, ln31 };

            // When
            ListNode answer = new LeetCode23().MergeKLists(ListNodes);

            // Then
            Assert.Equal(1, answer.Value);
            Assert.Equal(1, answer.Next.Value);
            Assert.Equal(2, answer.Next.Next.Value);
            Assert.Equal(3, answer.Next.Next.Next.Value);
            Assert.Equal(4, answer.Next.Next.Next.Next.Value);
            Assert.Equal(4, answer.Next.Next.Next.Next.Next.Value);
            Assert.Equal(5, answer.Next.Next.Next.Next.Next.Next.Value);
            Assert.Equal(6, answer.Next.Next.Next.Next.Next.Next.Next.Value);
        }
    }
}