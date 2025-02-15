namespace Algorithm.LeetCode.Test
{
    public class LeetCode82Test
    {
        [Fact]
        public void DeleteDuplicates_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln6 = new(3);
            ListNode ln5 = new(3, ln6);
            ListNode ln4 = new(2, ln5);
            ListNode ln3 = new(2, ln4);
            ListNode ln2 = new(1, ln3);
            ListNode ln1 = new(1, ln2);

            // When
            ListNode answer = new LeetCode82().DeleteDuplicates(ln1);

            // Then
            Assert.Equal(3, answer.Next.Next.Value);
        }
    }
}