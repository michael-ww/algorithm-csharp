namespace Algorithm.LeetCodeTest
{
    public class LeetCode878Test
    {
        [Fact]
        public void NthMagicalNumber_ValidInput_ReturnNumber()
        {
            // Given

            // When
            LeetCode878 leetCode878 = new();
            int answer1 = leetCode878.NthMagicalNumber(1, 2, 3);
            int answer2 = leetCode878.NthMagicalNumber(4, 2, 3);

            // Then
            Assert.Equal(2, answer1);
            Assert.Equal(6, answer2);
        }
    }
}