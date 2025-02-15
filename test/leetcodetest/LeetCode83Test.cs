namespace Algorithm.LeetCodeTest
{
    public class LeetCode83Test
    {
        [Fact]
        public void DeleteDuplicates1_ValidInput_ReturnHead()
        {
            //Arrange
            ListNode tail = new(4, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(2, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            ListNode answer1 = new LeetCode83().DeleteDuplicates1(head);

            //Assert
            Assert.Equal(4, answer1.Next.Next.Value);
            Assert.Null(answer1.Next.Next.Next);
        }


        [Fact]
        public void DeleteDuplicates2_ValidInput_ReturnHead()
        {
            //Arrange
            ListNode tail = new(4, null);
            ListNode seventh = new(4, tail);
            ListNode sixth = new(4, seventh);
            ListNode fifth = new(4, sixth);
            ListNode third = new(2, fifth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            ListNode answer2 = new LeetCode83().DeleteDuplicates2(head);

            //Assert
            Assert.Equal(4, answer2.Next.Next.Value);
            Assert.Null(answer2.Next.Next.Next);
        }
    }
}