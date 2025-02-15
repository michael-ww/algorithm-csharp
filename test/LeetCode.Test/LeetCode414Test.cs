namespace Algorithm.LeetCode.Test
{
    public class LeetCode414Test
    {
        [Fact]
        public void ThirdMax_ValidInput_ReturnThirdMaxNumber()
        {
            // Given
            int[] nums1 = { 3, 2, 1 };
            int[] nums2 = { 1, 2 };
            int[] nums3 = { 2, 2, 3, 1 };

            // When
            LeetCode414 leetCode414 = new();
            int answer1 = leetCode414.ThirdMax1(nums1);
            int answer2 = leetCode414.ThirdMax1(nums2);
            int answer3 = leetCode414.ThirdMax1(nums3);

            int answer4 = leetCode414.ThirdMax2(nums1);
            int answer5 = leetCode414.ThirdMax2(nums2);
            int answer6 = leetCode414.ThirdMax2(nums3);

            // Then
            Assert.Equal(1, answer1);
            Assert.Equal(2, answer2);
            Assert.Equal(1, answer3);

            Assert.Equal(1, answer4);
            Assert.Equal(2, answer5);
            Assert.Equal(1, answer6);

        }
    }
}