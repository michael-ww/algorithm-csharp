namespace Algorithm.LeetCodeTest
{
    public class LeetCode212Test
    {
        [Fact]
        public void FindWords_ValidInput_ReturnWords()
        {
            // Given
            char[][] board = [['o', 'a', 'a', 'n'], ['e', 't', 'a', 'e'], ['i', 'h', 'k', 'r'], ['i', 'f', 'l', 'v']];
            string[] words = ["oath", "pea", "eat", "rain"];

            // When
            LeetCode212 leetCode212 = new();
            IList<string> answer = leetCode212.FindWords(board, words);

            // Then
            Assert.Equal(2, answer.Count);
            Assert.Contains("eat", answer);
            Assert.Contains("oath", answer);
        }
    }
}