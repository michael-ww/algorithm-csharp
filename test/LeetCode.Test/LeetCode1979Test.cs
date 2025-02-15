namespace Algorithm.LeetCode.Test
{
    public class LeetCode1979Test
    {
        [Fact]
        public void FindGCD_ValidInput_ReturnGCD()
        {
            // Given
            int[] nums1 = [2, 5, 6, 9, 10], nums2 = [7, 5, 6, 8, 3], nums3 = [3, 3];

            // When
            LeetCode1979 leetCode1979 = new();
            int answer1 = leetCode1979.FindGCD(nums1);
            int answer2 = leetCode1979.FindGCD(nums2);
            int answer3 = leetCode1979.FindGCD(nums3);

            // Then
            Assert.Equal(2, answer1);
            Assert.Equal(1, answer2);
            Assert.Equal(3, answer3);
        }
    }
}