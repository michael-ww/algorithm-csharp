namespace Algorithm.LeetCodeTest
{
    public class LeetCode8Test
    {
        [Fact]
        public void MyAtoi_ValidInput_ReturnNumber()
        {
            //Arrange
            string s1 = "45632 Hello World";
            string s2 = "__-45632";
            string s3 = "45632";
            string s4 = "  &45632  ";


            //Act
            LeetCode8 leetCode8 = new();
            int answer1 = leetCode8.MyAtoi(s1);
            int answer2 = leetCode8.MyAtoi(s2);
            int answer3 = leetCode8.MyAtoi(s3);
            int answer4 = leetCode8.MyAtoi(s4);


            //Assert
            Assert.Equal(45632, answer1);
            Assert.Equal(-45632, answer2);
            Assert.Equal(45632, answer3);
            Assert.Equal(45632, answer4);
        }
    }
}