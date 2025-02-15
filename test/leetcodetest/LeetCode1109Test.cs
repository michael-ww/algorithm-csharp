namespace Algorithm.LeetCodeTest
{
    public class LeetCode1109Test
    {
        [Fact]
        public void CorpFlightBookings_ValidInput_ReturnSeats()
        {
            // Given
            int[][] bookings1 = [[1, 2, 10], [2, 3, 20], [2, 5, 25]], bookings2 = [[1, 2, 10], [2, 2, 15]];

            // When
            LeetCode1109 leetCode1109 = new();
            int[] answer1 = leetCode1109.CorpFlightBookings(bookings1, 5);
            int[] answer2 = leetCode1109.CorpFlightBookings(bookings2, 2);

            // Then
            Assert.Equal(5, answer1.Length);
            Assert.Contains(10, answer1);
            Assert.Contains(55, answer1);
            Assert.Contains(45, answer1);
            Assert.Contains(25, answer1);
            Assert.Contains(25, answer1);
            Assert.Equal(2, answer2.Length);
            Assert.Contains(10, answer2);
            Assert.Contains(25, answer2);
        }
    }
}