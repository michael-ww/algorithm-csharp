namespace Algorithm.LeetCodeTest
{
    public class LeetCode53Test
    {
        [Fact]
        public void MaxSubArray_ValidInput_ReturnMaxSum()
        {
            // Given
            int[] nums1 = [-2, 1, -3, 4, -1, 2, 1, -5, 4], nums2 = [1], nums3 = [5, 4, -1, 7, 8];

            // When
            LeetCode53 leetCode53 = new();
            int answer1 = leetCode53.MaxSubArray(nums1);
            int answer2 = leetCode53.MaxSubArray(nums2);
            int answer3 = leetCode53.MaxSubArray(nums3);


            // Then
            Assert.Equal(6, answer1);
            Assert.Equal(1, answer2);
            Assert.Equal(23, answer3);
        }
    }
}