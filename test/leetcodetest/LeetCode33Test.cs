namespace Algorithm.LeetCodeTest
{
    public class LeetCode33Test
    {
        [Fact]
        public void Search_ValidInupt_ReturnIndex()
        {
            // Given
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };

            // When
            LeetCode33 leetCode33 = new();
            int answer1 = leetCode33.Search(nums, 0);
            int answer2 = leetCode33.Search(nums, 3);

            // Then
            Assert.Equal(4, answer1);
            Assert.Equal(-1, answer2);
        }
    }
}