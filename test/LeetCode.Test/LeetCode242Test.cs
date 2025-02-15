namespace Algorithm.LeetCode.Test
{
    public class LeetCode242Test
    {
        [Fact]
        public void IsAnagram_ValidInput_ReturnBool()
        {
            // Given
            string s1 = "anagram", t1 = "nagaram";
            string s2 = "rat", t2 = "car";

            // When
            LeetCode242 leetCode242 = new();
            bool anagram11 = leetCode242.IsAnagram1(s1, t1);
            bool anagram12 = leetCode242.IsAnagram1(s2, t2);
            bool anagram21 = leetCode242.IsAnagram2(s1, t1);
            bool anagram22 = leetCode242.IsAnagram2(s2, t2);
            bool anagram31 = leetCode242.IsAnagram3(s1, t1);
            bool anagram32 = leetCode242.IsAnagram3(s2, t2);

            // Then
            Assert.True(anagram11);
            Assert.False(anagram12);
            Assert.True(anagram21);
            Assert.False(anagram22);
            Assert.True(anagram31);
            Assert.False(anagram32);
        }
    }
}