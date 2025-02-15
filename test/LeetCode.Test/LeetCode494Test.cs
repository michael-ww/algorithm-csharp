namespace Algorithm.LeetCode.Test
{
    public class LeetCode494Test
    {
        [Fact]
        public void FindTargetSumWays_ValidInput_ReturnCount()
        {
            // Given

            // When
            LeetCode494 leetCode494 = new();
            int answer11 = leetCode494.FindTargetSumWays1([1, 1, 1, 1, 1], 3);
            int answer12 = leetCode494.FindTargetSumWays1([1], 1);
            int answer21 = leetCode494.FindTargetSumWays2([1, 1, 1, 1, 1], 3);
            int answer22 = leetCode494.FindTargetSumWays2([1], 1);

            // Then
            Assert.Equal(5, answer11);
            Assert.Equal(1, answer12);
            Assert.Equal(5, answer21);
            Assert.Equal(1, answer22);
        }
    }
}