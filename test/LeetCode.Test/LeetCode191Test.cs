namespace Algorithm.LeetCode.Test
{
    public class LeetCode191Test
    {
        [Fact]
        public void HammingWeight_ValidInput_ReturnCount()
        {
            // Given
            int n1 = 11;

            // When
            LeetCode191 leetCode191 = new();
            int answer1 = leetCode191.HammingWeight(n1);

            // Then
            Assert.Equal(3, answer1);
        }
    }
}