namespace Algorithm.LeetCodeTest
{
    public class LeetCode46Test
    {
        [Fact]
        public void Permute_ValidInput_ReturnPermutation()
        {
            // Given
            int[] nums = { 1, 2, 3 };

            // When
            IList<IList<int>> answer = new LeetCode46().Permute(nums);

            // Then
            Assert.Equal(6, answer.Count);
            Assert.Contains(new List<int>() { 1, 2, 3 }, answer);
            Assert.Contains(new List<int>() { 1, 3, 2 }, answer);
            Assert.Contains(new List<int>() { 2, 1, 3 }, answer);
            Assert.Contains(new List<int>() { 2, 3, 1 }, answer);
            Assert.Contains(new List<int>() { 3, 1, 2 }, answer);
            Assert.Contains(new List<int>() { 3, 2, 1 }, answer);
        }
    }
}