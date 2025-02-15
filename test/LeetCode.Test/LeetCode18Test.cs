namespace Algorithm.LeetCode.Test
{
    public class LeetCode18Test
    {
        [Fact]
        public void FourSum_ValidInput_ReturnList()
        {
            // Given
            int[] nums1 = { 1, 0, -1, 0, -2, 2 };
            int[] nums2 = { 2, 2, 2, 2, 2 };

            // When
            LeetCode18 leetCode18 = new();
            IList<IList<int>> answer1 = leetCode18.FourSum(nums1, 0);
            IList<IList<int>> answer2 = leetCode18.FourSum(nums2, 8);

            // Then
            Assert.Equal(3, answer1.Count);
            Assert.Equal(1, answer2.Count);
        }
    }
}