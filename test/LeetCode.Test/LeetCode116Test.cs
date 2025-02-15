namespace Algorithm.LeetCode.Test
{
    public class LeetCode116Test
    {
        [Fact]
        public void Connect1_ValidInput_ReturnRoot()
        {
            // Given
            TreeNode seven = new(7);
            TreeNode six = new(6);
            TreeNode five = new(5);
            TreeNode four = new(4);
            TreeNode three = new(3)
            {
                Left = six,
                Right = seven
            };
            TreeNode two = new(2)
            {
                Left = four,
                Right = five
            };
            TreeNode one = new(1)
            {
                Left = two,
                Right = three
            };

            // When
            TreeNode answer = new LeetCode116().Connect1(one);

            // Then
            Assert.Equal(three, two.Next);
        }

        [Fact]
        public void Connect2_ValidInput_ReturnRoot()
        {
            // Given
            TreeNode seven = new(7);
            TreeNode six = new(6);
            TreeNode five = new(5);
            TreeNode four = new(4);
            TreeNode three = new(3)
            {
                Left = six,
                Right = seven
            };
            TreeNode two = new(2)
            {
                Left = four,
                Right = five
            };
            TreeNode one = new(1)
            {
                Left = two,
                Right = three
            };

            // When
            TreeNode answer = new LeetCode116().Connect2(one);

            // Then
            Assert.Equal(three, two.Next);
        }
    }
}