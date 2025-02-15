namespace Algorithm.LeetCode.Test
{
    public class LeetCode2426Test
    {
        [Fact]
        public void NumberOfPairs_ValidInput_ReturnCount()
        {
            // Given

            // When
            LeetCode2426 leetCode2426 = new();
            long answer1 = leetCode2426.NumberOfPairs([3, 2, 5], [2, 2, 1], 1);
            long answer2 = leetCode2426.NumberOfPairs([3, -1], [-2, 2], -1);

            // Then
            Assert.Equal(3, answer1);
            Assert.Equal(0, answer2);
        }
    }
}