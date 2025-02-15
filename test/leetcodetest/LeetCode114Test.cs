namespace Algorithm.LeetCodeTest
{
    public class LeetCode114Test
    {
        [Fact]
        public void Flatten1_ValidInput_ExpectSuccess()
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
            new LeetCode114().Flatten1(one);

            // Then
            Assert.Equal(2, one.Right.Value);
        }

        [Fact]
        public void Flatten2_ValidInput_ExpectSuccess()
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
            new LeetCode114().Flatten2(one);

            // Then
            Assert.Equal(2, one.Right.Value);
        }
    }
}