namespace Algorithm.LeetCodeTest
{
    public class LeetCode389Test
    {
        [Fact]
        public void FindTheDifference_ValidInput_ReturnChar()
        {
            // Given
            string s = "abcd", t = "abcde";

            // When
            LeetCode389 leetCode389 = new();
            char answer1 = leetCode389.FindTheDifference1(s, t);
            char answer2 = leetCode389.FindTheDifference2(s, t);
            char answer3 = leetCode389.FindTheDifference3(s, t);

            // Then
            Assert.Equal('e', answer1);
            Assert.Equal('e', answer2);
            Assert.Equal('e', answer3);
        }
    }
}