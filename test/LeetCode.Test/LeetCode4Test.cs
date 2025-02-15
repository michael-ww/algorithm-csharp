namespace Algorithm.LeetCode.Test
{
    public class LeetCode4Test
    {
        [Fact]
        public void FindMedianSortedArrays1_ValidInput1_ReturnMedian()
        {
            // Given
            int[] array1 = [-2, 2, 4];
            int[] array2 = [-1, 3, 6, 8];


            // When
            LeetCode4 leetCode4 = new();
            double median1 = leetCode4.FindMedianSortedArrays1(array1, null);
            double median2 = leetCode4.FindMedianSortedArrays1(null, array1);
            double median3 = leetCode4.FindMedianSortedArrays1(array2, null);
            double median4 = leetCode4.FindMedianSortedArrays1(null, array2);

            // Then
            Assert.Equal(2, median1);
            Assert.Equal(2, median2);
            Assert.Equal(4.5, median3);
            Assert.Equal(4.5, median4);
        }

        [Fact]
        public void FindMedianSortedArrays1_ValidInput2_ReturnMedian()
        {
            // Given
            int[] array1 = new int[] { 1, 2, 3 };

            // When
            LeetCode4 leetCode4 = new();
            double median1 = leetCode4.FindMedianSortedArrays1(array1, null);
            double median2 = leetCode4.FindMedianSortedArrays1(null, array1);

            // Then
            Assert.Equal(2, median1);
            Assert.Equal(2, median2);
        }

        [Fact]
        public void FindMedianSortedArrays2_ValidInput_ReturnMedian()
        {
            // Given

            // When

            // Then
        }

        [Fact]
        public void FindMedianSortedArrays3_ValidInput_ReturnMedian()
        {
            // Given

            // When

            // Then
        }
    }
}