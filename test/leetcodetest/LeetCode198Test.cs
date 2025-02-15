namespace Algorithm.LeetCodeTest
{
    public class LeetCode198Test
    {
        [Fact]
        public void Rob_ValidInput_ReturnMaxMoney()
        {
            // Given
            int[] nums1 = { 1, 2, 3, 1 };
            int[] nums2 = { 2, 7, 9, 3, 1 };

            // When
            LeetCode198 leetCode198 = new();
            int answer1 = leetCode198.Rob1(nums1);
            int answer2 = leetCode198.Rob1(nums2);
            int answer3 = leetCode198.Rob2(nums1);
            int answer4 = leetCode198.Rob2(nums2);

            // Then
            Assert.Equal(4, answer1);
            Assert.Equal(12, answer2);
            Assert.Equal(4, answer3);
            Assert.Equal(12, answer4);
        }
    }
}