namespace Algorithm.LeetCodeTest
{
    public class LeetCode866Test
    {
        [Fact]
        public void PrimePalindrome_ValidInput_ReturnPrimePalindrome()
        {
            // Given

            // When
            LeetCode866 leetCode866 = new();
            int answer1 = leetCode866.PrimePalindrome(6);
            int answer2 = leetCode866.PrimePalindrome(8);
            int answer3 = leetCode866.PrimePalindrome(13);


            // Then
            Assert.Equal(7, answer1);
            Assert.Equal(11, answer2);
            Assert.Equal(101, answer3);
        }
    }
}