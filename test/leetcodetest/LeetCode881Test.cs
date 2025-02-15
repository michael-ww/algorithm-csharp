namespace Algorithm.LeetCodeTest
{
    public class LeetCode881Test
    {
        [Fact]
        public void NumRescueBoats_ValidInput_ReturnCount()
        {
            // Given
            int[] people1 = [1, 2], people2 = [3, 2, 2, 1], people3 = [3, 5, 3, 4];
            int limit1 = 3, limit2 = 3, limit3 = 5;

            // When
            LeetCode881 leetCode881 = new();
            int answer1 = leetCode881.NumRescueBoats(people1, limit1);
            int answer2 = leetCode881.NumRescueBoats(people2, limit2);
            int answer3 = leetCode881.NumRescueBoats(people3, limit3);

            // Then
            Assert.Equal(1, answer1);
            Assert.Equal(3, answer2);
            Assert.Equal(4, answer3);
        }
    }
}