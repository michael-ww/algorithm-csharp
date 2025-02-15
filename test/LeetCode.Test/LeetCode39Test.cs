namespace Algorithm.LeetCode.Test
{
    public class LeetCode39Test
    {
        [Fact]
        public void CombinationSum_ValidInput_ReturnCombinations()
        {
            // Given

            // When
            LeetCode39 leetCode39 = new();
            IList<IList<int>> answer1 = leetCode39.CombinationSum([2, 3, 6, 7], 7);
            IList<IList<int>> answer2 = leetCode39.CombinationSum([2, 3, 5], 8);
            IList<IList<int>> answer3 = leetCode39.CombinationSum([2], 1);

            // Then
            Assert.Equal(2, answer1.Count);
            Assert.Contains([2, 2, 3], answer1);
            Assert.Contains([7], answer1);

            Assert.Equal(3, answer2.Count);
            Assert.Contains([2, 2, 2, 2], answer2);
            Assert.Contains([2, 3, 3], answer2);
            Assert.Contains([3, 5], answer2);

            Assert.Equal(0, answer3.Count);

        }
    }
}