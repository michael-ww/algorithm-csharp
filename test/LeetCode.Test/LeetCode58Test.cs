namespace Algorithm.LeetCode.Test
{
    public class LeetCode58Test
    {
        [Fact]
        public void LengthOfLastWord1_ValidInput_ReturnLength()
        {
            // Given
            string s1 = "Hello World";
            string s2 = "   fly me   to   the moon  ";
            string s3 = "luffy is still joyboy";

            // When
            LeetCode58 leetCode58 = new();
            int answer1 = leetCode58.LengthOfLastWord1(s1);
            int answer2 = leetCode58.LengthOfLastWord1(s2);
            int answer3 = leetCode58.LengthOfLastWord1(s3);

            // Then
            Assert.Equal(5, answer1);
            Assert.Equal(4, answer2);
            Assert.Equal(6, answer3);
        }

        [Fact]
        public void LengthOfLastWord2_ValidInput_ReturnLength()
        {
            // Given
            string s1 = "Hello World";
            string s2 = "   fly me   to   the moon  ";
            string s3 = "luffy is still joyboy";

            // When
            LeetCode58 leetCode58 = new();
            int answer1 = leetCode58.LengthOfLastWord2(s1);
            int answer2 = leetCode58.LengthOfLastWord2(s2);
            int answer3 = leetCode58.LengthOfLastWord2(s3);

            // Then
            Assert.Equal(5, answer1);
            Assert.Equal(4, answer2);
            Assert.Equal(6, answer3);
        }
    }
}