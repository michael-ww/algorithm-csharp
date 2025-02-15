namespace Algorithm.LeetCodeTest
{
    public class LeetCode153Test
    {
        [Fact]
        public void FindMin_ValidInput_ReturnMin()
        {
            // Given
            int[] nums1 = [3, 4, 5, 1, 2], nums2 = [4, 5, 6, 7, 0, 1, 2], nums3 = [11, 13, 15, 17];

            // When
            LeetCode153 leetCode153 = new();
            int answer1 = leetCode153.FindMin(nums1);
            int answer2 = leetCode153.FindMin(nums2);
            int answer3 = leetCode153.FindMin(nums3);

            // Then
            Assert.Equal(1, answer1);
            Assert.Equal(0, answer2);
            Assert.Equal(11, answer3);
        }
    }
}