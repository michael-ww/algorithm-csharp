namespace Algorithm.LeetCodeTest
{
    public class LeetCode962Test
    {
        [Fact]
        public void MaxWidthRamp_ValidInput_ReturnMaxWidth()
        {
            // Arrange

            // Act
            LeetCode962 leetCode962 = new();
            int answer1 = leetCode962.MaxWidthRamp([6, 0, 8, 2, 1, 5]);
            int answer2 = leetCode962.MaxWidthRamp([9, 8, 1, 0, 1, 9, 4, 0, 4, 1]);

            // Assert
            Assert.Equal(4, answer1);
            Assert.Equal(7, answer2);
        }
    }
}