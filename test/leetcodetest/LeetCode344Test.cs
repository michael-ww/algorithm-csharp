namespace Algorithm.LeetCodeTest
{
    public class LeetCode344Test
    {
        [Fact]
        public void ReverseString_ValidInput_Success()
        {
            // Given
            char[] chars1 = { 'h', 'e', 'l', 'l', 'o' };
            char[] chars2 = { 'H', 'a', 'n', 'n', 'a', 'h' };

            // When
            LeetCode344 leetCode344 = new();
            leetCode344.ReverseString(chars1);
            leetCode344.ReverseString(chars2);

            // Then
            Assert.Equal(new char[] { 'o', 'l', 'l', 'e', 'h' }, chars1);
            Assert.Equal(new char[] { 'h', 'a', 'n', 'n', 'a', 'H' }, chars2);

        }
    }
}