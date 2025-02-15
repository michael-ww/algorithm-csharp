namespace Algorithm.LeetCode.Test
{
    public class LeetCode35Test
    {
        [Fact]
        public void SearchInsert_ValidInput_ReturnIndex()
        {
            // Given
            int[] nums1 = { 1, 3, 5, 6 };

            // When
            LeetCode35 leetCode35 = new();
            int answer1 = leetCode35.SearchInsert(nums1, 5);
            int answer2 = leetCode35.SearchInsert(nums1, 2);
            int answer3 = leetCode35.SearchInsert(nums1, 7);
            int answer4 = leetCode35.SearchInsert(nums1, 0);


            // Then
            Assert.Equal(2, answer1);
            Assert.Equal(1, answer2);
            Assert.Equal(4, answer3);
            Assert.Equal(0, answer4);
        }
    }
}