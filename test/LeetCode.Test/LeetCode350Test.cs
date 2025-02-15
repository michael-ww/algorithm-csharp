namespace Algorithm.LeetCode.Test
{
    public class LeetCode350Test
    {
        [Fact]
        public void Intersect_ValidInput_ReturnArray()
        {
            // Given
            int[] nums11 = { 1, 2, 2, 1 }, nums21 = { 2, 2 };
            int[] nums12 = { 4, 9, 5 }, nums22 = { 9, 4, 9, 8, 4 };

            // When
            LeetCode350 leetCode350 = new();
            int[] answer1 = leetCode350.Intersect(nums11, nums21);
            int[] answer2 = leetCode350.Intersect(nums12, nums22);


            // Then
            Assert.Equal(2, answer1.Length);
            Assert.Contains(2, answer1);
            Assert.Equal(2, answer2.Length);
            Assert.Contains(9, answer2);
            Assert.Contains(4, answer2);
        }
    }
}