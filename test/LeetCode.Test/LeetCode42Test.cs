namespace Algorithm.LeetCode.Test
{
    public class LeetCode42Test
    {
        [Fact]
        public void Trap_ValidInput_ReturnRainfall()
        {
            // Given
            int[] height1 = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1], height2 = [4, 2, 0, 3, 2, 5];

            // When
            LeetCode42 leetCode42 = new();
            int answer11 = leetCode42.Trap1(height1);
            int answer12 = leetCode42.Trap2(height2);
            int answer21 = leetCode42.Trap2(height1);
            int answer22 = leetCode42.Trap2(height2);

            // Then
            Assert.Equal(6, answer11);
            Assert.Equal(9, answer12);
            Assert.Equal(6, answer21);
            Assert.Equal(9, answer22);
        }
    }
}