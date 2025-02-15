namespace Algorithm.LeetCode.Test
{
    public class LeetCode285Test
    {
        [Fact]
        public void InorderSuccessor_ValidInput_ReturnSuccessor()
        {
            // Given
            TreeNode seven = new(7);
            TreeNode six = new(5);
            TreeNode five = new(3);
            TreeNode four = new(1);
            TreeNode three = new(6)
            {
                Left = six,
                Right = seven
            };
            TreeNode two = new(2)
            {
                Left = four,
                Right = five
            };
            TreeNode one = new(4)
            {
                Left = two,
                Right = three
            };

            // When
            LeetCode285 leetCode285 = new();
            TreeNode answer1 = leetCode285.InorderSuccessor(one, six);
            TreeNode answer2 = leetCode285.InorderSuccessor(one, three);
            TreeNode answer3 = leetCode285.InorderSuccessor(one, five);

            // Then
            Assert.Equal(6, answer1.Value);
            Assert.Equal(7, answer2.Value);
            Assert.Equal(4, answer3.Value);

        }
    }
}