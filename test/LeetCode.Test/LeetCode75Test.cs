namespace Algorithm.LeetCode.Test
{
    public class LeetCode75Test
    {
        [Fact]
        public void SortColors_ValidInput_Succeed()
        {
            // Given
            int[] nums1 = { 2, 0, 2, 1, 1, 0 };
            int[] nums2 = { 2, 0, 1 };

            // When
            LeetCode75 leetCode75 = new();
            leetCode75.SortColors(nums1);
            leetCode75.SortColors(nums2);

            // Then
            Assert.Equal(0, nums1[0]);
            Assert.Equal(0, nums1[1]);
            Assert.Equal(1, nums1[2]);
            Assert.Equal(1, nums1[3]);
            Assert.Equal(2, nums1[4]);
            Assert.Equal(2, nums1[5]);
            Assert.Equal(0, nums2[0]);
            Assert.Equal(1, nums2[1]);
            Assert.Equal(2, nums2[2]);
        }
    }
}