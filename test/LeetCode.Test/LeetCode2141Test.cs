namespace Algorithm.LeetCode.Test
{
    public class LeetCode2141Test
    {
        [Fact]
        public void MaxRunTime_ValidInput_ReturnMaxRunTime()
        {
            // Given
            int n1 = 2, n2 = 2;
            int[] batteries1 = [3, 3, 3], batteries2 = [1, 1, 1, 1];

            // When
            LeetCode2141 leetCode2141 = new();
            long answer1 = leetCode2141.MaxRunTime(n1, batteries1);
            long answer2 = leetCode2141.MaxRunTime(n2, batteries2);

            // Then
            Assert.Equal(4, answer1);
            Assert.Equal(2, answer2);
        }
    }
}