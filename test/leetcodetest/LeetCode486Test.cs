namespace Algorithm.LeetCodeTest
{
    public class LeetCode486Test
    {
        [Fact]
        public void PredictTheWinner1_ValidInput_ReturnBoolean()
        {
            // Given
            int[] nums1 = { 1, 5, 2 };
            int[] nums2 = { 1, 5, 233, 7 };

            // When
            LeetCode486 leetCode486 = new();
            bool answer1 = leetCode486.PredictTheWinner1(nums1);
            bool answer2 = leetCode486.PredictTheWinner1(nums2);

            // Then
            Assert.False(answer1);
            Assert.True(answer2);
        }

        [Fact]
        public void PredictTheWinner2_ValidInput_ReturnBoolean()
        {
            // Given
            int[] nums1 = { 1, 5, 2 };
            int[] nums2 = { 1, 5, 233, 7 };

            // When
            LeetCode486 leetCode486 = new();
            bool answer1 = leetCode486.PredictTheWinner2(nums1);
            bool answer2 = leetCode486.PredictTheWinner2(nums2);

            // Then
            Assert.False(answer1);
            Assert.True(answer2);
        }

        [Fact]
        public void PredictTheWinner3_ValidInput_ReturnBoolean()
        {
            // Given
            int[] nums1 = { 1, 5, 2 };
            int[] nums2 = { 1, 5, 233, 7 };

            // When
            LeetCode486 leetCode486 = new();
            bool answer1 = leetCode486.PredictTheWinner3(nums1);
            bool answer2 = leetCode486.PredictTheWinner3(nums2);

            // Then
            Assert.False(answer1);
            Assert.True(answer2);
        }
    }
}