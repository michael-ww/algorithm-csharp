namespace Algorithm.LeetCodeTest
{
    public class LeetCode41Test
    {
        [Fact]
        public void FirstMissingPositive_ValidInput_ReturnMissingPositive()
        {
            // Given
            int[] nums1 = [1, 2, 0], nums2 = [3, 4, -1, 1], nums3 = [7, 8, 9, 11, 12];

            // When
            LeetCode41 leetCode41 = new();
            int answer1 = leetCode41.FirstMissingPositive(nums1);
            int answer2 = leetCode41.FirstMissingPositive(nums2);
            int answer3 = leetCode41.FirstMissingPositive(nums3);

            // Then
            Assert.Equal(3, answer1);
            Assert.Equal(2, answer2);
            Assert.Equal(1, answer3);
        }
    }
}