namespace Algorithm.LeetCodeTest
{
    public class LeetCode199Test
    {
        [Fact]
        public void RightSideView_ValidInput_ReturnList()
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
            IList<int> answer = new LeetCode199().RightSideView(one);

            // Then
            Assert.Equal(3, answer.Count);
            Assert.Contains(1, answer);
            Assert.Contains(3, answer);
            Assert.Contains(7, answer);
        }
    }
}