namespace Belly.Algorithm
{
    public class LeetCode688Test
    {
        [Fact]
        public void KnightProbability1_ValidInput_ReturnProbability()
        {
            // Given

            // When
            LeetCode688 leetCode688 = new();
            double answer1 = leetCode688.KnightProbability1(3, 2, 0, 0);
            double answer2 = leetCode688.KnightProbability1(1, 0, 0, 0);
            double answer3 = leetCode688.KnightProbability1(9, 7, 3, 4);
            double answer4 = leetCode688.KnightProbability1(13, 10, 6, 7);

            // Then
            Assert.Equal(0.0625, answer1);
            Assert.Equal(1.0000, answer2);
            Assert.Equal(0.29372501373291016, answer3);
            Assert.Equal(0.46947479620575905, answer4);
        }

        [Fact]
        public void KnightProbability2_ValidInput_ReturnProbability()
        {
            // Given

            // When
            LeetCode688 leetCode688 = new();
            double answer1 = leetCode688.KnightProbability2(3, 2, 0, 0);
            double answer2 = leetCode688.KnightProbability2(1, 0, 0, 0);
            double answer3 = leetCode688.KnightProbability2(9, 7, 3, 4);
            double answer4 = leetCode688.KnightProbability2(13, 10, 6, 7);

            // Then
            Assert.Equal(0.0625, answer1);
            Assert.Equal(1.0000, answer2);
            Assert.Equal(0.29372501373291016, answer3);
            Assert.Equal(0.46947479620575905, answer4);
        }

        [Fact]
        public void KnightProbability3_ValidInput_ReturnProbability()
        {
            // Given

            // When
            LeetCode688 leetCode688 = new();
            double answer1 = leetCode688.KnightProbability3(3, 2, 0, 0);
            double answer2 = leetCode688.KnightProbability3(1, 0, 0, 0);
            double answer3 = leetCode688.KnightProbability3(9, 7, 3, 4);
            double answer4 = leetCode688.KnightProbability3(13, 10, 6, 7);

            // Then
            Assert.Equal(0.0625, answer1);
            Assert.Equal(1.0000, answer2);
            Assert.Equal(0.29372501373291016, answer3);
            Assert.Equal(0.46947479620575905, answer4);
        }
    }
}