namespace Algorithm.LeetCodeTest
{
    public class LeetCode234Test
    {
        [Fact]
        public void IsPalindrome1_ValidInputOdd_ReturnFalse()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome1(head);

            //Assert
            Assert.False(answer);
        }

        [Fact]
        public void IsPalindrome1_ValidInputOdd_ReturnTrue()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(2, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome1(head);

            //Assert
            Assert.True(answer);
        }

        [Fact]
        public void IsPalindrome1_ValidInputEven_ReturnFalse()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(3, tail);
            ListNode second = new(2, fouth);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome1(head);

            //Assert
            Assert.False(answer);
        }

        [Fact]
        public void IsPalindrome1_ValidInputEven_ReturnTrue()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(2, tail);
            ListNode second = new(2, fouth);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome1(head);

            //Assert
            Assert.True(answer);
        }

        [Fact]
        public void IsPalindrome2_ValidInputOdd_ReturnFalse()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome2(head);

            //Assert
            Assert.False(answer);
        }

        [Fact]
        public void IsPalindrome2_ValidInputOdd_ReturnTrue()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(2, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome2(head);

            //Assert
            Assert.True(answer);
        }

        [Fact]
        public void IsPalindrome2_ValidInputEven_ReturnFalse()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(3, tail);
            ListNode second = new(2, fouth);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome2(head);

            //Assert
            Assert.False(answer);
        }

        [Fact]
        public void IsPalindrome2_ValidInputEven_ReturnTrue()
        {
            //Arrange
            ListNode tail = new(1, null);
            ListNode fouth = new(2, tail);
            ListNode second = new(2, fouth);
            ListNode head = new(1, second);

            //Act
            LeetCode234 leetCode234 = new();
            bool answer = leetCode234.IsPalindrome2(head);

            //Assert
            Assert.True(answer);
        }
    }
}