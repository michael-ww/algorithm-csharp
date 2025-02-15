namespace Algorithm.LeetCode.Test
{
    public class LeetCode13Test
    {
        [Fact]
        public void RomanToInt_ValidInput_ReturnInt()
        {
            //Arrange
            string input1 = "LVIII";
            string input2 = "MCMXCIV";

            //Act
            int answer1 = new LeetCode13().RomanToInt(input1);
            int answer2 = new LeetCode13().RomanToInt(input2);

            //Assert
            Assert.Equal(58, answer1);
            Assert.Equal(1994, answer2);
        }
    }
}