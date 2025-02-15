namespace Algorithm.LeetCodeTest
{
    public class LeetCode875Test
    {
        [Fact]
        public void MinEatingSpeed_ValidInput_ReturnSpeed()
        {
            // Given
            int[] piles1 = [3, 6, 7, 11], piles2 = [30, 11, 23, 4, 20], piles3 = [30, 11, 23, 4, 20];
            int h1 = 8, h2 = 5, h3 = 6;

            // When
            LeetCode875 leetCode875 = new();
            int answer1 = leetCode875.MinEatingSpeed(piles1, h1);
            int answer2 = leetCode875.MinEatingSpeed(piles2, h2);
            int answer3 = leetCode875.MinEatingSpeed(piles3, h3);

            // Then
            Assert.Equal(4, answer1);
            Assert.Equal(30, answer2);
            Assert.Equal(23, answer3);
        }
    }
}