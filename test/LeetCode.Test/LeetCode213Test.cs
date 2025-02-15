namespace Algorithm.LeetCode.Test
{
    public class LeetCode213Test
    {
        [Fact]
        public void Rob_ValidInput_ReturnMaxMoney()
        {
            // Given
            int[] nums1 = { 2, 3, 2 };
            int[] nums2 = { 1, 2, 3, 1 };
            int[] nums3 = { 1, 2, 3 };

            // When
            LeetCode213 leetCode213 = new();
            int answer1 = leetCode213.Rob(nums1);
            int answer2 = leetCode213.Rob(nums2);
            int answer3 = leetCode213.Rob(nums3);

            // Then
            Assert.Equal(3, answer1);
            Assert.Equal(4, answer2);
            Assert.Equal(3, answer3);
        }
    }
}