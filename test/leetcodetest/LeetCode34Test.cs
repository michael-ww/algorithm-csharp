namespace Algorithm.LeetCodeTest
{
    public class LeetCode34Test
    {
        [Fact]
        public void SearchRange_ValidInput_ReturnRange()
        {
            //Arrange
            int[] nums1 = { 5, 7, 7, 8, 8, 10 };
            int[] nums2 = Array.Empty<int>();
            int target1 = 8;
            int target2 = 6;

            //Act
            LeetCode34 leetCode34 = new();
            int[] answer1 = leetCode34.SearchRange(nums1, target1);
            int[] answer2 = leetCode34.SearchRange(nums1, target2);
            int[] answer3 = leetCode34.SearchRange(nums2, target1);

            //Assert
            Assert.Equal([3, 4], answer1);
            Assert.Equal([-1, -1], answer2);
            Assert.Equal([-1, -1], answer3);
        }
    }
}