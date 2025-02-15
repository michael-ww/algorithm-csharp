namespace Algorithm.LeetCodeTest
{
    public class LeetCode257Test
    {
        [Fact]
        public void BinaryTreePaths_ValidInput_ReturnPaths()
        {
            // Given
            TreeNode five = new(5);
            TreeNode three = new(3);
            TreeNode two = new(2)
            {
                Right = five
            };
            TreeNode one = new(1)
            {
                Left = two,
                Right = three
            };

            // When
            IList<string> answer = new LeetCode257().BinaryTreePaths(one);

            // Then
            Assert.Contains("1->2->5", answer);
            Assert.Contains("1->3", answer);
        }
    }
}