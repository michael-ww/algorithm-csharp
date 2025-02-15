namespace Algorithm.LeetCodeTest
{
    public class LeetCode303Test
    {
        [Fact]
        public void SumRange_ValidInput_ReturnSum()
        {
            // Given
            int[] nums = [-2, 0, 3, -5, 2, -1];

            // When
            LeetCode303 leetCode303 = new(nums);
            int answer1 = leetCode303.SumRange(0, 2);
            int answer2 = leetCode303.SumRange(2, 5);
            int answer3 = leetCode303.SumRange(0, 5);

            // Then
            Assert.Equal(1, answer1);
            Assert.Equal(-1, answer2);
            Assert.Equal(-3, answer3);
        }
    }
}