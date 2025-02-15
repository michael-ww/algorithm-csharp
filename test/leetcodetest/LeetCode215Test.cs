namespace Algorithm.LeetCodeTest
{
    public class LeetCode215Test
    {
        [Fact]
        public void FindKthLargest1_InValidInput_ThrowException()
        {
            //Arrange
            int[] nums1 = null;
            int[] nums2 = Array.Empty<int>();
            int[] nums3 = new int[] { 3, 8, 4, 1, 6 };
            int kth = 8;

            //Act
            LeetCode215 leetCode215 = new();

            //Assert
            Assert.ThrowsAny<Exception>(() => leetCode215.FindKthLargest1(nums1, kth));
            Assert.ThrowsAny<Exception>(() => leetCode215.FindKthLargest1(nums2, kth));
            Assert.ThrowsAny<Exception>(() => leetCode215.FindKthLargest1(nums3, kth));
        }

        [Fact]
        public void FindKthLargest1_ValidInput_ReturnKthNumber()
        {
            //Arrange
            int[] nums1 = new int[] { 3, 2, 1, 5, 6, 4 };
            int[] nums2 = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int[] nums3 = new int[] { 3, 8, 4, 1, 6, 5, 3, 4, 5, 7, 5, 8, 5, 9, 5, 0 };
            int kth1 = 2, kth2 = 4, kth3 = 6;

            //Act
            LeetCode215 leetCode215 = new();
            int kthNumber1 = leetCode215.FindKthLargest1(nums1, kth1);
            int kthNumber2 = leetCode215.FindKthLargest1(nums2, kth2);
            int kthNumber3 = leetCode215.FindKthLargest1(nums3, kth3);


            //Assert
            Assert.Equal(5, kthNumber1);
            Assert.Equal(4, kthNumber2);
            Assert.Equal(5, kthNumber3);
        }

        [Fact]
        public void FindKthLargest2_InValidInput_ThrowException()
        {
            //Arrange
            int[] nums1 = null;
            int[] nums2 = Array.Empty<int>();
            int[] nums3 = new int[] { 3, 8, 4, 1, 6 };
            int kth = 8;

            //Act
            LeetCode215 leetCode215 = new();

            //Assert
            Assert.ThrowsAny<Exception>(() => leetCode215.FindKthLargest2(nums1, kth));
            Assert.ThrowsAny<Exception>(() => leetCode215.FindKthLargest2(nums2, kth));
            Assert.ThrowsAny<Exception>(() => leetCode215.FindKthLargest2(nums3, kth));
        }

        [Fact]
        public void FindKthLargest2_ValidInput_ReturnKthNumber()
        {
            //Arrange
            int[] nums1 = new int[] { 3, 2, 1, 5, 6, 4 };
            int[] nums2 = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int[] nums3 = new int[] { 3, 8, 4, 1, 6, 5, 3, 4, 5, 7, 5, 8, 5, 9, 5, 0 };
            int kth1 = 2, kth2 = 4, kth3 = 6;

            //Act
            LeetCode215 leetCode215 = new();
            int kthNumber1 = leetCode215.FindKthLargest2(nums1, kth1);
            int kthNumber2 = leetCode215.FindKthLargest2(nums2, kth2);
            int kthNumber3 = leetCode215.FindKthLargest2(nums3, kth3);


            //Assert
            Assert.Equal(5, kthNumber1);
            Assert.Equal(4, kthNumber2);
            Assert.Equal(5, kthNumber3);
        }

        [Fact]
        public void FindKthLargest3_ValidInput_ReturnKthNumber()
        {
            //Arrange
            int[] nums1 = new int[] { 3, 2, 1, 5, 6, 4 };
            int[] nums2 = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int[] nums3 = new int[] { 3, 8, 4, 1, 6, 5, 3, 4, 5, 7, 5, 8, 5, 9, 5, 0 };
            int kth1 = 2, kth2 = 4, kth3 = 6;

            //Act
            LeetCode215 leetCode215 = new();
            int kthNumber1 = leetCode215.FindKthLargest3(nums1, kth1);
            int kthNumber2 = leetCode215.FindKthLargest3(nums2, kth2);
            int kthNumber3 = leetCode215.FindKthLargest3(nums3, kth3);


            //Assert
            Assert.Equal(5, kthNumber1);
            Assert.Equal(4, kthNumber2);
            Assert.Equal(5, kthNumber3);
        }
    }
}