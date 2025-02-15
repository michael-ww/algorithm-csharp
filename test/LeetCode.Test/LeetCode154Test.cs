namespace Algorithm.LeetCode.Test
{
    public class LeetCode154Test
    {
        [Fact]
        public void FindMin_ValidInput_ReturnMin()
        {
            // Given
            int[] nums1 = [4, 5, 6, 7, 0, 1, 4], nums2 = [2, 2, 2, 0, 1];

            // When
            LeetCode154 leetCode154 = new();
            int answer1 = leetCode154.FindMin(nums1);
            int answer2 = leetCode154.FindMin(nums2);

            // Then
            Assert.Equal(0, answer1);
            Assert.Equal(0, answer2);
        }
    }
}