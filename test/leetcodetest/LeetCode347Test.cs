namespace Algorithm.LeetCodeTest
{
    public class LeetCode347Test
    {
        [Fact]
        public void TopKFrequent_ValidInput_ReturnArray()
        {
            // Given
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            // When
            int[] answer = new LeetCode347().TopKFrequent(nums, k);

            // Then
            Assert.Equal(2, answer.Length);
            Assert.Equal(1, answer[0]);
            Assert.Equal(2, answer[1]);
        }
    }
}