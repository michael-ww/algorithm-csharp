namespace Belly.Algorithm
{
    public class LeetCode124Test
    {
        [Fact]
        public void MaxPathSum_ValidInput_ReturnMaxDistance()
        {
            // Given
            TreeNode seven = new(-7);
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
            int answer = new LeetCode124().MaxPathSum(one);

            // Then
            Assert.Equal(17, answer);
        }
    }
}