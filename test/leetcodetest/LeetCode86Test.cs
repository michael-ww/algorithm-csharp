namespace Belly.Algorithm
{
    public class LeetCode86Test
    {
        [Fact]
        public void Partition_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln9 = new(8);
            ListNode ln8 = new(4, ln9);
            ListNode ln7 = new(7, ln8);
            ListNode ln6 = new(2, ln7);
            ListNode ln5 = new(3, ln6);
            ListNode ln4 = new(6, ln5);
            ListNode ln3 = new(5, ln4);
            ListNode ln2 = new(1, ln3);
            ListNode ln1 = new(9, ln2);

            // When
            ListNode answer = new LeetCode86().Partition1(ln1, 5);

            // Then
            Assert.Equal(1, answer.Value);
        }
    }
}