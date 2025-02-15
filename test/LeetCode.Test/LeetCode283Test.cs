namespace Algorithm.LeetCode.Test
{
    public class LeetCode283Test
    {
        [Fact]
        public void MoveZeroes_ValidInput_Succeed()
        {
            // Given
            int[] nums = { 0, 1, 0, 3, 12 };

            // When
            new LeetCode283().MoveZeroes(nums);

            // Then
            Assert.Equal(1, nums[0]);
            Assert.Equal(0, nums[^1]);
        }
    }
}