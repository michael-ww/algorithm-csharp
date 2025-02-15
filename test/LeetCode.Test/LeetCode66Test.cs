namespace Algorithm.LeetCode.Test
{
    public class LeetCode66Test
    {
        [Fact]
        public void PlusOne_ValidInput_ReturnArray()
        {
            // Given
            int[] digits1 = { 1, 2, 3 };
            int[] digits2 = { 9, 9, 9, 9 };
            int[] digits3 = { 1, 5, 4, 9, 9 };

            // When
            int[] answer1 = new LeetCode66().PlusOne(digits1);
            int[] answer2 = new LeetCode66().PlusOne(digits2);
            int[] answer3 = new LeetCode66().PlusOne(digits3);

            // Then
            Assert.Equal(new int[] { 1, 2, 4 }, answer1);
            Assert.Equal(new int[] { 1, 0, 0, 0, 0 }, answer2);
            Assert.Equal(new int[] { 1, 5, 5, 0, 0 }, answer3);

        }
    }
}