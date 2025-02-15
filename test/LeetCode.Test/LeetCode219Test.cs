namespace Belly.Algorithm
{
    public class LeetCode219Test
    {
        [Fact]
        public void ContainsNearbyDuplicate_ValidInput_ReturnBoolean()
        {
            // Given
            int[] nums1 = { 1, 2, 3, 1 }, nums2 = { 1, 0, 1, 1 }, nums3 = { 1, 2, 3, 1, 2, 3 };
            int k1 = 3, k2 = 1, k3 = 2;

            // When
            LeetCode219 leetCode219 = new();
            bool answer11 = leetCode219.ContainsNearbyDuplicate1(nums1, k1);
            bool answer12 = leetCode219.ContainsNearbyDuplicate1(nums2, k2);
            bool answer13 = leetCode219.ContainsNearbyDuplicate1(nums3, k3);
            bool answer21 = leetCode219.ContainsNearbyDuplicate2(nums1, k1);
            bool answer22 = leetCode219.ContainsNearbyDuplicate2(nums2, k2);
            bool answer23 = leetCode219.ContainsNearbyDuplicate2(nums3, k3);

            // Then
            Assert.True(answer11);
            Assert.True(answer12);
            Assert.False(answer13);
            Assert.True(answer21);
            Assert.True(answer22);
            Assert.False(answer23);
        }
    }
}