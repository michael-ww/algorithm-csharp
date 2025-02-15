namespace Algorithm.LeetCode.Test
{
    public class LeetCode144Test
    {
        [Fact]
        public void PreorderTraversal3_ValidInput_ReturnAscendingArray()
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
            LeetCode144 leetCode144 = new();
            IList<int> answer1 = leetCode144.PreorderTraversal1(one);
            IList<int> answer2 = leetCode144.PreorderTraversal1(one);
            IList<int> answer3 = leetCode144.PreorderTraversal1(one);

            // Then
            List<int> expected = new() { 1, 2, 4, 5, 3, 6, 7 };
            Assert.Equal(expected, answer1);
            Assert.Equal(expected, answer2);
            Assert.Equal(expected, answer3);
        }
    }
}