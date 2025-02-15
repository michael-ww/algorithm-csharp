namespace Algorithm.LeetCode.Test
{
    public class LeetCode98Test
    {
        [Fact]
        public void IsBST1_ValidInput_ReturnBool()
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
            LeetCode98 leetCode98 = new();
            bool answer1 = leetCode98.IsValidBST1(one);
            bool answer2 = leetCode98.IsValidBST2(one);
            bool answer3 = leetCode98.IsValidBST3(one);

            // Then
            Assert.False(answer1);
            Assert.False(answer2);
            Assert.False(answer3);
        }

        [Fact]
        public void IsBST2_ValidInput_ReturnBool()
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
            LeetCode98 leetCode98 = new();
            bool answer1 = leetCode98.IsValidBST1(one);
            bool answer2 = leetCode98.IsValidBST2(one);
            bool answer3 = leetCode98.IsValidBST3(one);

            // Then
            Assert.True(answer1);
            Assert.True(answer2);
            Assert.True(answer3);
        }
    }
}