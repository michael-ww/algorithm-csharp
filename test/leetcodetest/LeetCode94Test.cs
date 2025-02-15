namespace Algorithm.LeetCodeTest
{
    public class LeetCode94Test
    {
        [Fact]
        public void InorderTraversal_ValidInput_ReturnInorder()
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
            LeetCode94 leetCode94 = new();
            IList<int> answer1 = leetCode94.InorderTraversal1(one);
            IList<int> answer2 = leetCode94.InorderTraversal2(one);
            IList<int> answer3 = leetCode94.InorderTraversal3(one);

            // Then
            List<int> expected = new() { 4, 2, 5, 1, 6, 3, 7 };
            Assert.Equal(expected, answer1);
            Assert.Equal(expected, answer2);
            Assert.Equal(expected, answer3);
        }
    }
}