namespace Algorithm.LeetCodeTest
{
    public class LeetCode111Test
    {
        [Fact]
        public void MinDepth_ValidInput_ReturnDepth()
        {
            // Given
            TreeNode five = new(5);
            TreeNode four = new(4);
            TreeNode three = new(3);
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
            int answer = new LeetCode111().MinDepth(one);

            // Then
            Assert.Equal(2, answer);
        }
    }
}