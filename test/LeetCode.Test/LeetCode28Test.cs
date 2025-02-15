namespace Algorithm.LeetCode.Test
{
    public class LeetCode28Test
    {
        [Fact]
        public void StrStr1_ValidInput_ReturnIndex()
        {
            // Given
            string haystack1 = "sadbutsad", needle1 = "sad";
            string haystack2 = "leetcode", needle2 = "leeto";

            // When
            int answer1 = new LeetCode28().StrStr1(haystack1, needle1);
            int answer2 = new LeetCode28().StrStr1(haystack2, needle2);

            // Then
            Assert.Equal(0, answer1);
            Assert.Equal(-1, answer2);
        }

        [Fact]
        public void StrStr2_ValidInput_ReturnIndex()
        {
            // Given
            string haystack1 = "sadbutsad", needle1 = "sad";
            string haystack2 = "leetcode", needle2 = "leeto";

            // When
            int answer1 = new LeetCode28().StrStr2(haystack1, needle1);
            int answer2 = new LeetCode28().StrStr2(haystack2, needle2);

            // Then
            Assert.Equal(0, answer1);
            Assert.Equal(-1, answer2);
        }

        [Fact]
        public void StrStr3_ValidInput_ReturnIndex()
        {
            // Given
            string haystack1 = "sadbutsad", needle1 = "sad";
            string haystack2 = "leetcode", needle2 = "leeto";

            // When
            int answer1 = new LeetCode28().StrStr3(haystack1, needle1);
            int answer2 = new LeetCode28().StrStr3(haystack2, needle2);

            // Then
            Assert.Equal(0, answer1);
            Assert.Equal(-1, answer2);
        }
    }
}