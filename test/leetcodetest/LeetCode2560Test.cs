namespace Algorithm.LeetCodeTest
{
    public class LeetCode2560Test
    {
        [Fact]
        public void MinCapability_ValidInput_ReturnMinCapability()
        {
            // Given

            // When
            LeetCode2560 leetCode2560 = new();
            int answer1 = leetCode2560.MinCapability([2, 3, 5, 9], 2);
            int answer2 = leetCode2560.MinCapability([2, 7, 9, 3, 1], 2);

            // Then
            Assert.Equal(5, answer1);
            Assert.Equal(2, answer2);
        }
    }
}