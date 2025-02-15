namespace Algorithm.LeetCodeTest
{
    public class LeetCode11Test
    {
        [Fact]
        public void MaxArea_ValidInput_ReturnArea()
        {
            // Given
            int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] height2 = { 1, 1 };

            // When
            LeetCode11 leetCode11 = new();
            int answer1 = leetCode11.MaxArea(height1);
            int answer2 = leetCode11.MaxArea(height2);

            // Then
            Assert.Equal(49, answer1);
            Assert.Equal(1, answer2);
        }
    }
}