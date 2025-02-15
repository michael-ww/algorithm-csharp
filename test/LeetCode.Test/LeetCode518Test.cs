namespace Algorithm.LeetCode.Test
{
    public class LeetCode518Test
    {
        [Fact]
        public void Change_ValidInput1_ReturnWays()
        {
            // Given
            int[] coins = { 1, 2, 5 };
            int amount = 5;

            // When
            LeetCode518 leetCode518 = new();
            int answer1 = leetCode518.Change1(amount, coins);
            int answer2 = leetCode518.Change2(amount, coins);
            int answer3 = leetCode518.Change3(amount, coins);
            int answer4 = leetCode518.Change4(amount, coins);
            int answer5 = leetCode518.Change5(amount, coins);

            // Then
            Assert.Equal(4, answer1);
            Assert.Equal(4, answer2);
            Assert.Equal(4, answer3);
            Assert.Equal(4, answer4);
            Assert.Equal(4, answer5);
        }

        [Fact]
        public void Change_ValidInput2_ReturnWays()
        {
            // Given
            int[] coins = Utility.GenerateArray(length: 7, maxValue: 10, distinct: true);
            int amount = 10;

            // When
            LeetCode518 leetCode518 = new();
            int answer1 = leetCode518.Change1(amount, coins);
            int answer2 = leetCode518.Change2(amount, coins);
            int answer3 = leetCode518.Change3(amount, coins);
            int answer4 = leetCode518.Change4(amount, coins);
            int answer5 = leetCode518.Change5(amount, coins);

            // Then
            Assert.Equal(answer1, answer2);
            Assert.Equal(answer2, answer3);
            Assert.Equal(answer3, answer4);
            Assert.Equal(answer4, answer5);
        }
    }
}