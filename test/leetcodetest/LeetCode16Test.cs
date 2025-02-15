namespace Algorithm.LeetCodeTest
{
    public class LeetCode16Test
    {
        [Fact]
        public void ThreeSumClosest_ValidInput_ReturnSum()
        {
            // Given
            int[] nums1 = { -1, 2, 1, -4 };
            int[] nums2 = { 0, 0, 0 };
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };

            // When
            LeetCode16 leetCode16 = new();
            int answer1 = leetCode16.ThreeSumClosest(nums1, 1);
            int answer2 = leetCode16.ThreeSumClosest(nums2, 1);
            int answer3 = leetCode16.ThreeSumClosest(nums3, 1);

            // Then
            Assert.Equal(2, answer1);
            Assert.Equal(0, answer2);
            Assert.Equal(1, answer3);
        }
    }
}