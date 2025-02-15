namespace Algorithm.LeetCodeTest
{
    public class LeetCode1234Test
    {
        [Fact]
        public void BalancedString_ValidInput_ReturnLength()
        {
            // Given
            string s1 = "QWER", s2 = "QQWE", s3 = "QQQW", s4 = "QQQQ";

            // When
            LeetCode1234 leetCode1234 = new();
            int answer1 = leetCode1234.BalancedString(s1);
            int answer2 = leetCode1234.BalancedString(s2);
            int answer3 = leetCode1234.BalancedString(s3);
            int answer4 = leetCode1234.BalancedString(s4);


            // Then
            Assert.Equal(0, answer1);
            Assert.Equal(1, answer2);
            Assert.Equal(2, answer3);
            Assert.Equal(3, answer4);
        }
    }
}