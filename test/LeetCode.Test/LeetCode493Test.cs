namespace Algorithm.LeetCode.Test
{
    public class LeetCode493Test
    {
        [Fact]
        public void ReversePairs_ValidInput_ReturnReversePairCount()
        {
            // Given
            int[] nums1 = [1, 3, 2, 3, 1], nums2 = [2, 4, 3, 5, 1];

            // When
            LeetCode493 leetCode493 = new();
            int answer1 = leetCode493.ReversePairs(nums1);
            int answer2 = leetCode493.ReversePairs(nums2);

            // Then
            Assert.Equal(2, answer1);
            Assert.Equal(3, answer2);
        }
    }
}