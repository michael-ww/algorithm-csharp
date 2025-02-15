namespace Algorithm.LeetCodeTest
{
    public class LeetCode167Test
    {
        [Fact]
        public void TwoSum_ValidInput_ReturnIndexes()
        {
            // Given
            int[] numbers1 = [2, 7, 11, 15], numbers2 = [2, 3, 4], numbers3 = [-1, 0];
            int target1 = 9, target2 = 6, target3 = -1;

            // When
            LeetCode167 leetCode167 = new();
            int[] answer1 = leetCode167.TwoSum(numbers1, target1);
            int[] answer2 = leetCode167.TwoSum(numbers2, target2);
            int[] answer3 = leetCode167.TwoSum(numbers3, target3);

            // Then
            Assert.Equal(1, answer1[0]);
            Assert.Equal(2, answer1[1]);
            Assert.Equal(1, answer2[0]);
            Assert.Equal(3, answer2[1]);
            Assert.Equal(1, answer3[0]);
            Assert.Equal(2, answer3[1]);
        }
    }
}