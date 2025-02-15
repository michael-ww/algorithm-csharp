namespace Algorithm.LeetCodeTest
{
    public class LeetCode103Test
    {
        [Fact]
        public void ZigzagLevelOrder_ValidInput_ReturnLevelTraversal()
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
            IList<IList<int>> answer = new LeetCode103().ZigzagLevelOrder(one);

            // Then
            Assert.Equal(1, answer[0].Count);
            Assert.Equal(1, answer[0][0]);
            Assert.Equal(2, answer[1].Count);
            Assert.Equal(3, answer[1][0]);
            Assert.Equal(2, answer[1][1]);
            Assert.Equal(4, answer[2].Count);
            Assert.Equal(4, answer[2][0]);
            Assert.Equal(5, answer[2][1]);
            Assert.Equal(6, answer[2][2]);
            Assert.Equal(7, answer[2][3]);

        }
    }
}