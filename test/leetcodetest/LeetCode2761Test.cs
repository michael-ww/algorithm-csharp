namespace Algorithm.LeetCodeTest
{
    public class LeetCode2761Test
    {
        [Fact]
        public void FindPrimePairs_ValidInput_ReturnPairs()
        {
            // Given

            // When
            LeetCode2761 leetCode2761 = new();
            IList<IList<int>> answer1 = leetCode2761.FindPrimePairs(10);
            IList<IList<int>> answer2 = leetCode2761.FindPrimePairs(2);

            // Then
            Assert.Contains([3, 7], answer1);
            Assert.Contains([5, 5], answer1);
            Assert.Empty(answer2);
        }
    }
}