namespace Algorithm.LeetCode.Test
{
    public class LeetCode81Test
    {
        [Fact]
        public void Search_ValidInput_ReturnIndex()
        {
            // Given
            int[] nums = [2, 5, 6, 0, 0, 1, 2];
            int target1 = 0, target2 = 3;

            // When
            LeetCode81 leetCode81 = new();
            bool answer1 = leetCode81.Search(nums, target1);
            bool answer2 = leetCode81.Search(nums, target2);

            // Then
            Assert.True(answer1);
            Assert.False(answer2);
        }
    }
}