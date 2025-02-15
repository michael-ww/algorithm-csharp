namespace Algorithm.LeetCode.Test
{
    public class LeetCode342Test
    {
        [Fact]
        public void IsPowerOfFour_ValidInput_ReturnBoolean()
        {
            // Given

            // When
            LeetCode342 leetCode342 = new();
            bool answer1 = leetCode342.IsPowerOfFour1(16);
            bool answer2 = leetCode342.IsPowerOfFour1(5);
            bool answer3 = leetCode342.IsPowerOfFour1(1);
            bool answer4 = leetCode342.IsPowerOfFour2(16);
            bool answer5 = leetCode342.IsPowerOfFour2(5);
            bool answer6 = leetCode342.IsPowerOfFour2(1);

            // Then
            Assert.True(answer1);
            Assert.False(answer2);
            Assert.True(answer3);
            Assert.True(answer4);
            Assert.False(answer5);
            Assert.True(answer6);
        }
    }
}