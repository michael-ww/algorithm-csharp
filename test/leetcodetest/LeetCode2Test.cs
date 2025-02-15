namespace Algorithm.LeetCodeTest
{

    public class LeetCode2Test
    {
        [Fact]
        public void AddTowNumbers_ValidInput_ReturnHeadNode()
        {
            //Arrange
            ListNode l11 = new(6, null);
            ListNode l1 = new(9, l11);
            ListNode l22 = new(5, null);
            ListNode l2 = new(2, l22);

            //Act
            ListNode result = new LeetCode2().AddTwoNumbers(l1, l2);

            //Assert
            Assert.Equal(1, result.Value);
            Assert.Equal(2, result.Next.Value);
            Assert.Equal(1, result.Next.Next.Value);
            Assert.Null(result.Next.Next.Next);

        }
    }
}