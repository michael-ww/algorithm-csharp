namespace Belly.Algorithm
{
    public class LeetCode530Test
    {
        [Fact]
        public void GetMinimumDifference1_ValidInput_ReturnMinimumDifference()
        {
            // Given
            TreeNode six = new(6);
            TreeNode three = new(3);
            TreeNode one = new(1);
            TreeNode two = new(2)
            {
                Left = one,
                Right = three
            };
            TreeNode four = new(4)
            {
                Left = two,
                Right = six
            };

            // When
            int answer = new LeetCode530().GetMinimumDifference(four);

            // Then
            Assert.Equal(1, answer);
        }

        [Fact]
        public void GetMinimumDifference2_ValidInput_ReturnMinimumDifference()
        {
            // Given
            TreeNode twelve = new(12);
            TreeNode fourtynine = new(49);
            TreeNode fourtyeight = new(48)
            {
                Left = twelve,
                Right = fourtynine
            };
            TreeNode zero = new(0);
            TreeNode one = new(1)
            {
                Left = zero,
                Right = fourtyeight
            };

            // When
            int answer = new LeetCode530().GetMinimumDifference(one);

            // Then
            Assert.Equal(1, answer);
        }
    }
}