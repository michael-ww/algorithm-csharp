namespace Algorithm.LeetCodeTest
{
    public class LeetCode260Test
    {
        [Fact]
        public void SingleNumber_ValidInput_ReturnSingleNumbers()
        {
            // Given
            int[] nums = { 1, -7, 2, 1, 3, 2, 5, -7 };

            // When
            int[] answer = new LeetCode260().SingleNumber(nums);

            // Then
            Assert.Contains(3, answer);
            Assert.Contains(5, answer);
        }
    }
}