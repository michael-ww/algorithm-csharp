namespace Algorithm.LeetCode.Test
{
    public class LeetCode168Test
    {
        [Fact]
        public void ConvertToTitle_ValidInput_ReturnTitle()
        {
            // Given
            int nums1 = 1;
            int nums2 = 28;
            int nums3 = 701;
            int nums4 = 2147483647;

            // When
            LeetCode168 leetCode168 = new();
            string answer1 = leetCode168.ConvertToTitle(nums1);
            string answer2 = leetCode168.ConvertToTitle(nums2);
            string answer3 = leetCode168.ConvertToTitle(nums3);
            string answer4 = leetCode168.ConvertToTitle(nums4);

            // Then
            Assert.Equal("A", answer1);
            Assert.Equal("AB", answer2);
            Assert.Equal("ZY", answer3);
            Assert.Equal("FXSHRXW", answer4);

        }
    }
}