namespace Algorithm.LeetCodeTest
{
    public class LeetCode268Test
    {
        [Fact]
        public void MissingNumber_ValidInput_ReturnNumber()
        {
            // Given
            int[] nums1 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int[] nums2 = { 3, 0, 1 };

            // When
            LeetCode268 leetCode268 = new();
            int answer11 = leetCode268.MissingNumber1(nums1);
            int answer12 = leetCode268.MissingNumber1(nums2);
            int answer21 = leetCode268.MissingNumber2(nums1);
            int answer22 = leetCode268.MissingNumber2(nums2);
            int answer31 = leetCode268.MissingNumber3(nums1);
            int answer32 = leetCode268.MissingNumber3(nums2);
            int answer41 = leetCode268.MissingNumber4(nums1);
            int answer42 = leetCode268.MissingNumber4(nums2);

            // Then
            Assert.Equal(8, answer11);
            Assert.Equal(2, answer12);
            Assert.Equal(8, answer21);
            Assert.Equal(2, answer22);
            Assert.Equal(8, answer31);
            Assert.Equal(2, answer32);
            Assert.Equal(8, answer41);
            Assert.Equal(2, answer42);
        }
    }
}