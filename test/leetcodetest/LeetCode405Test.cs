namespace Algorithm.LeetCodeTest
{
    public class LeetCode405Test
    {
        [Fact]
        public void ToHex_ValidInput_ReturnHex()
        {
            // Given

            // When
            LeetCode405 leetCode405 = new();
            string answer1 = leetCode405.ToHex(26);
            string answer2 = leetCode405.ToHex(-1);

            // Then
            Assert.Equal("1a", answer1);
            Assert.Equal("ffffffff", answer2);
        }
    }
}