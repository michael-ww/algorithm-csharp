namespace Algorithm.LeetCodeTest
{
    public class LeetCode392Test
    {
        [Fact]
        public void IsSubsequence_ValidInput_ReturBoolean()
        {
            // Given
            string s1 = "abc", t1 = "ahbgdc";
            string s2 = "axc", t2 = "ahbgdc";

            // When
            LeetCode392 leetCode392 = new();
            bool answer1 = leetCode392.IsSubsequence(s1, t1);
            bool answer2 = leetCode392.IsSubsequence(s2, t2);

            // Then
            Assert.True(answer1);
            Assert.False(answer2);
        }
    }
}