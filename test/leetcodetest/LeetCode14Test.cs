namespace Algorithm.LeetCodeTest
{
    public class LeetCode14Test
    {
        [Fact]
        public void LongestCommonPrefix_ValidInput_ReturnPrefix()
        {
            // Given
            string[] strs1 = { "flower", "flow", "flight" };
            string[] strs2 = { "dog", "racecar", "car" };

            // When
            string answer1 = new LeetCode14().LongestCommonPrefix(strs1);
            string answer2 = new LeetCode14().LongestCommonPrefix(strs2);

            // Then
            Assert.Equal("fl", answer1);
            Assert.Empty(answer2);
        }
    }
}