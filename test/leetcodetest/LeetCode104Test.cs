namespace Algorithm.LeetCodeTest
{
    public class LeetCode104Test
    {
        [Fact]
        public void MaxDepth_ValidInput_ReturnHeight()
        {
            // Given
            TreeNode seven = new(4);
            TreeNode six = new(5);
            TreeNode five = new(5);
            TreeNode four = new(4);
            TreeNode three = new(3)
            {
                Left = six,
                Right = seven
            };
            TreeNode two = new(3)
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
            int answer = new LeetCode104().MaxDepth(one);

            // Then
            Assert.Equal(3, answer);
        }
    }
}