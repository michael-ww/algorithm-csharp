namespace Algorithm.LeetCode.Test
{
    public class LeetCode394Test
    {
        [Fact]
        public void DecodeString_ValidInput_ReturnString()
        {
            // Given
            string s1 = "3[a]2[bc]", s2 = "3[a2[c]]", s3 = "2[abc]3[cd]ef", s4 = "abc3[cd]xyz";

            // When
            LeetCode394 leetCode394 = new();
            string answer1 = leetCode394.DecodeString(s1);
            string answer2 = leetCode394.DecodeString(s2);
            string answer3 = leetCode394.DecodeString(s3);
            string answer4 = leetCode394.DecodeString(s4);

            // Then
            Assert.Equal("aaabcbc", answer1);
            Assert.Equal("accaccacc", answer2);
            Assert.Equal("abcabccdcdcdef", answer3);
            Assert.Equal("abccdcdcdxyz", answer4);

        }
    }
}